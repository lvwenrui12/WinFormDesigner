using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Guanjinke.Windows.Forms
{
    public class ToolBoxItemCollection : Collection<ToolBoxItem>
    {
        public event CollectionChangeEventHandler ItemChanged;

        public ToolBoxItemCollection()
        {
            ItemChanged += new CollectionChangeEventHandler(OnToolBoxItemCollectionChanged);
        }

        protected override void InsertItem(int index, ToolBoxItem item)
        {
            base.InsertItem(index, item);
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
        }

        protected override void RemoveItem(int index)
        {
            ToolBoxItem ti = base[index];
            base.RemoveItem(index);
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Remove, ti));
        }

        protected override void SetItem(int index, ToolBoxItem item)
        {
            base.SetItem(index, item);
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Refresh, item));
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null));
        }

        public ToolBoxItem this[String name]
        {
            get
            {
                Int32 index = -1;
                for (Int32 i = 0; i < this.Count; i++)
                {
                    if (this[i].Name == name)
                    {
                        index = i;
                        break;
                    }
                }

                if (index >= 0 && index < this.Count)
                {
                    return this[index];
                }

                return null;
            }
        }

        protected virtual void OnToolBoxItemCollectionChanged(Object sender, CollectionChangeEventArgs e)
        {
        }
    }
}
