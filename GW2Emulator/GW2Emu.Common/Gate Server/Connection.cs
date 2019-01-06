using System;
using System.Collections.Generic;
using System.Net.Sockets;


namespace GW2Emu.Common
{
    public class Connection
    {
        private Account _account;

        public Account Account
        {
            get { return _account; }
            set
            {
                if (value.connection != null)
                    value.connection.Socket.Close();

                _account = value;
                _account.connection = this;
            }
        }

        public Socket Socket;

        public ConnectionBuffer Buffer = new ConnectionBuffer();

        public ICipher Decoder;
        public ICipher Encoder;

        private readonly Queue<byte[]> _sendData = new Queue<byte[]>();
        private readonly AsyncLock _sendLock = new AsyncLock();
        private bool _isSendInProgress;

        public async void Send(byte[] data)
        {
            byte[][] sendData;

            using (await _sendLock.LockAsync())
            {
                if (Encoder != null)
                    Encoder.Process(ref data, 0, data.Length);

                _sendData.Enqueue(data);
                if (_isSendInProgress)
                    return;
                _isSendInProgress = true;

                sendData = _sendData.ToArray();
                _sendData.Clear();
            }

            Send(sendData);
        }

        private void Send(byte[][] data)
        {
            int bufferSize = 0;
            for (int i = 0; i < data.Length; i++)
                bufferSize += data[i].Length;

            byte[] buffer = new byte[bufferSize];
            int pointer = 0;
            for (int i = 0; i < data.Length; i++)
            {
                System.Buffer.BlockCopy(data[i], 0, buffer, pointer, data[i].Length);
                pointer += data[i].Length;
            }

            Socket.BeginSend(buffer, 0, bufferSize, SocketFlags.None, SendCallback, null);
        }

        private async void SendCallback(IAsyncResult result)
        {
            try
            {
                Socket.EndSend(result);

                byte[][] sendData;

                using (await _sendLock.LockAsync())
                {
                    if (_sendData.Count == 0)
                    {
                        _isSendInProgress = false;
                        return;
                    }

                    sendData = _sendData.ToArray();
                    _sendData.Clear();
                }

                Send(sendData);
            }
            catch (SocketException)
            {
                Socket.Disconnect(true);
            }
            catch (Exception)
            {
                Socket.Disconnect(true);
            }
        }
    }
}
