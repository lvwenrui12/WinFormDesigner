using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Guanjinke.Windows.Forms
{
    public class ToolBoxCategoryCollection : Collection<ToolBoxCategory>
    {
        public event CollectionChangeEventHandler ItemChanged;

        public ToolBoxCategoryCollection()
        {
            ItemChanged += new CollectionChangeEventHandler(OnToolBoxCategoryCollectionChanged);
        }

        protected override void InsertItem(int index, ToolBoxCategory item)
        {
            base.InsertItem(index, item);
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
        }

        protected override void RemoveItem(int index)
        {
            ToolBoxCategory tc = base[index];
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Remove, tc));
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, ToolBoxCategory item)
        {
            base.SetItem(index, item);
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Refresh, item));
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            ItemChanged(this, new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null));
        }

        public ToolBoxCategory this[String name]
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

        protected virtual void OnToolBoxCategoryCollectionChanged(Object sender, CollectionChangeEventArgs e)
        {
        }
    }
}
