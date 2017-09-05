using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Guanjinke.Windows.Forms
{
    public class ToolBoxCategory : ToolBoxItem
    {
        #region fields
        private ToolBoxItemCollection _items = null;
        private Boolean _isOpen = false;
        #endregion

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ToolBoxItemCollection Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public Boolean IsOpen
        {
            get
            {
                return _isOpen;
            }
            set
            {
                _isOpen = value;
            }
        }
        #endregion

        public ToolBoxCategory()
        {
            _items = new ToolBoxItemCollection();
        }
    }
}
