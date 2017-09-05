using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace Guanjinke.Windows.Forms
{
    public class ToolBoxItem
    {
        private String _name = "";
        private Int32 _imageIndex = -1;
        private ToolBoxItem _parent = null;
        private object _tag = null;
        private Image _image = null;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Int32 ImageIndex
        {
            get
            {
                return _imageIndex;
            }
            set
            {
                _imageIndex = value;
            }
        }

        [Browsable(false)]
        public ToolBoxItem Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public object Tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }

        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }
    }
}
