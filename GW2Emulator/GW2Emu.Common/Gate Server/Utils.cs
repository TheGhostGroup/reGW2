using System;
using System.Globalization;
using System.Text;

namespace GW2Emu.Common
{
    public static class Utils
    {

        public static readonly Random Random = new Random((int) DateTime.Now.Ticks);

        private static readonly string[] Baths;

        static Utils()
        {
            Baths = new string[256];
            for (int i = 0; i < 256; i++)
                Baths[i] = String.Format("{0:X2}", i);
        }

        public static string ToHex(this byte[] array)
        {
            StringBuilder builder = new StringBuilder(array.Length << 1);

            for (int i = 0; i < array.Length; i++)
                builder.Append(Baths[array[i]]);

            return builder.ToString();
        }

        public static string ToUidString(this byte[] array)
        {
            StringBuilder builder = new StringBuilder(20);

            builder.Append(Baths[array[3]]);
            builder.Append(Baths[array[2]]);
            builder.Append(Baths[array[1]]);
            builder.Append(Baths[array[0]]);
            builder.Append("-");
            builder.Append(Baths[array[5]]);
            builder.Append(Baths[array[4]]);
            builder.Append("-");
            builder.Append(Baths[array[7]]);
            builder.Append(Baths[array[6]]);
            builder.Append("-");
            builder.Append(Baths[array[8]]);
            builder.Append(Baths[array[9]]);
            builder.Append("-");
            builder.Append(Baths[array[10]]);
            builder.Append(Baths[array[11]]);
            builder.Append(Baths[array[12]]);
            builder.Append(Baths[array[13]]);
            builder.Append(Baths[array[14]]);
            builder.Append(Baths[array[15]]);

            return builder.ToString();
        }

        public static byte[] ToBytes(this String hexString)
        {
            try
            {
                byte[] result = new byte[hexString.Length >> 1];

                for (int index = 0; index < result.Length; index++)
                {
                    string byteValue = hexString.Substring(index << 1, 2);
                    result[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}