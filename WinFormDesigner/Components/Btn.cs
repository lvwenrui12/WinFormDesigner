using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HelperClass;

namespace WinFormDesigner.Components
{
   public class Btn:IComponent
    {
        private  Button btn=new Button();
        private List<byte[]> btnByteList;
        private byte[] btnPara = null;

        public byte[] ParaToByte()
        {
            if (btn==null)
            {
                return null;
            }
            btnByteList = new List<byte[]>();
        
            int wid = btn.Width;

          

            byte wid0 = Convert.ToByte((wid / 0x100) & 0xff);
            byte wid1 = Convert.ToByte(wid & 0xff); //低位

            byte height0 = Convert.ToByte((btn.Height / 0x100) & 0xff);
            byte height1 = Convert.ToByte(btn.Height & 0xff); //低位

            byte x0 = Convert.ToByte((btn.Location.X / 0x100) & 0xff);
            byte x1 = Convert.ToByte(btn.Location.X & 0xff); //低位

            byte y0 = Convert.ToByte((btn.Location.Y / 0x100) & 0xff);
            byte y1 = Convert.ToByte(btn.Location.Y & 0xff); //低位

            byte[] btnText = Encoding.ASCII.GetBytes(btn.Text);

            byte colorR = Convert.ToByte(btn.ForeColor.R);
            byte colorG = Convert.ToByte(btn.ForeColor.G);
            byte colorB = Convert.ToByte(btn.ForeColor.B);
            byte[] foreColor = { colorR, colorG, colorB };

            byte[] btnParaByte = {wid0, wid1, height0, height1, x0, x1, y0, y1 };
            btnByteList.Add(new byte[] { 0x02 });
            btnByteList.Add(btnParaByte);

            btnByteList.Add(foreColor);
            btnByteList.Add(btnText);
            btnPara = ByteHelper.MergerArray(btnByteList);
          
            btnPara = ByteHelper.AddMediaPro(btnPara);

            return btnPara;
        }

        public Btn(Button btn)
        {
            this.btn = btn;


        }
    }
}
