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
            byte[] result = {};
            First.CopyTo(result, 0);
            Second.CopyTo(result, result.Length);
            return result;
        }

        public static byte[] MergerArray(byte[] First, byte[] Second,byte[] Third)
        {
            byte[] result = {};
            First.CopyTo(result, result.Length);
            Second.CopyTo(result, result.Length);
            Third.CopyTo(result, result.Length);
            return result;
        }

        public static byte[] MergerArray(List<byte[]> byteList)
        {
            byte[] result = {};
            foreach (var item in byteList)
            {
                item.CopyTo(result,result.Length);
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
