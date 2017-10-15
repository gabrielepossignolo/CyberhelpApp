using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberhelp.Models
{
    public class MyListReport<TKey, TItem> : ObservableCollection<TItem>
    {
        public TKey key { get; set; }

        public MyListReport(TKey key, IEnumerable<TItem> items)
        {
            this.key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
