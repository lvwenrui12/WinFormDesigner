using System;
using System.CodeDom;
using System.Collections.Generic;

using System.Text;

namespace HelperClass
{
  public  class ByteHelper
    {

        public static byte[] MergerArray(byte[] First, byte[] Second)
        {
            byte[] result = new byte[First.Length + Second.Length];
            First.CopyTo(result, 0);
            Second.CopyTo(result, First.Length);
            return result;
        }

        public static byte[] MergerArray(byte[] First, byte[] Second,byte[] Third)
        {
            byte[] result = new byte[First.Length + Second.Length+Third.Length];
            First.CopyTo(result, 0);
            Second.CopyTo(result, First.Length);
            Third.CopyTo(result, First.Length + Second.Length);
            return result;
        }

        public static byte[] MergerArray(List<byte[]> byteList)
        {
            int length = 0;
            foreach (var item in byteList)
            {
                length += item.Length;
            }

            byte[] result = new byte[length];
            length = 0;
            foreach (var item in byteList)
            {
                
                item.CopyTo(result, length);
                length += item.Length;
            }
            return result;
            
        }

        public static string ByteToString(byte[] bytes)

        {

            StringBuilder strBuilder = new StringBuilder();

            foreach (byte bt in bytes)

            {

                strBuilder.AppendFormat("{0:X2} ", bt);

            }

            return strBuilder.ToString();

        }

        public static byte[] StringToByte(string str)
        {
            return System.Text.Encoding.Default.GetBytes(str);

           
        }



    }
}
