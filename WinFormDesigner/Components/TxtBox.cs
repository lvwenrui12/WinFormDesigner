using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HelperClass;

namespace WinFormDesigner.Components
{
   public class TxtBox:IComponent
    {
        private List<byte[]> textByteList;
        private  TextBox txtBox;
        public byte[] ParaToByte()
        {
            textByteList = new List<byte[]>();
         
            int wid = txtBox.Width;

            byte wid0 = Convert.ToByte((wid / 0x100) & 0xff);
            byte wid1 = Convert.ToByte(wid & 0xff); //低位

            byte height0 = Convert.ToByte((txtBox.Height / 0x100) & 0xff);
            byte height1 = Convert.ToByte(txtBox.Height & 0xff); //低位

            byte x0 = Convert.ToByte((txtBox.Location.X / 0x100) & 0xff);
            byte x1 = Convert.ToByte(txtBox.Location.X & 0xff); //低位

            byte y0 = Convert.ToByte((txtBox.Location.Y / 0x100) & 0xff);
            byte y1 = Convert.ToByte(txtBox.Location.Y & 0xff); //低位

            byte[] txtText = Encoding.ASCII.GetBytes(txtBox.Text);

            byte colorR = Convert.ToByte(txtBox.ForeColor.R);
            byte colorG = Convert.ToByte(txtBox.ForeColor.G);
            byte colorB = Convert.ToByte(txtBox.ForeColor.B);
            byte[] foreColor = { colorR, colorG, colorB };

            byte[] txtParaByte = { wid0, wid1, height0, height1, x0, x1, y0, y1 };
            textByteList.Add(new byte[] { 0x01 });

            textByteList.Add(txtParaByte);

            textByteList.Add(foreColor);
            textByteList.Add(txtText);
            return ByteHelper.AddMediaPro(ByteHelper.MergerArray(textByteList));

        }

        public TxtBox(TextBox txtBox)
        {
            this.txtBox = txtBox;

        }
    }
}
