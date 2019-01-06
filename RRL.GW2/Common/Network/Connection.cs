using System;
using System.Collections.Generic;
using System.Net.Sockets;
using RRL.GW2.Common.Crypto;
using RRL.GW2.Common.Data.Account;
using RRL.GW2.Common.Tools;
using log4net;

namespace RRL.GW2.Common.Network
{
    /// <summary>
    /// Author: Alehandr
    /// </summary>
    public class Connection
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Connection));

        private Account _account;

        public Account Account
        {
            get { return _account; }
            set
            {
                if (value.Connection != null)
                    value.Connection.Socket.Close();

                _account = value;
                _account.Connection = this;
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
            catch (SocketException exc)
            {
                Socket.Disconnect(true);
                Log.DebugFormat("Socket exception: {0}", exc.SocketErrorCode.ToString());
            }
            catch (Exception exc)
            {
                Socket.Disconnect(true);
                Log.Error("Exception: ", exc);
            }
        }
    }
}
