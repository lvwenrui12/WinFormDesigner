using System;
using System.CodeDom;
using System.Collections.Generic;

using System.Text;

namespace HelperClass
{
  public  class ByteHelper
    {
        public static byte[] AddMediaPro(byte[] sendByte)
        {
            byte lenth0 = Convert.ToByte(((sendByte.Length + 4) / 0x100) & 0xff);
            byte lenth1 = Convert.ToByte((sendByte.Length + 4) & 0xff); //低位

            byte[] head = {0xAA, lenth0 , lenth1 };
            byte[] end = {0x55};
          return  MergerArray(head, sendByte,end);
        }


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
