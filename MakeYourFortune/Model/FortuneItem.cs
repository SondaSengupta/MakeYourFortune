using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MakeYourFortune.Model
{
    public class FortuneItem
    {
        public static ObservableCollection<FortuneItem> Fortunes = new ObservableCollection<FortuneItem>();

        public string FortuneText;
        public string FortuneCategory;

        public FortuneItem(string FortuneText, string FortuneCategory)
        {
            this.FortuneText = FortuneText;
            this.FortuneCategory = FortuneCategory;
            Fortunes.Add(this);
        }
    }
}
