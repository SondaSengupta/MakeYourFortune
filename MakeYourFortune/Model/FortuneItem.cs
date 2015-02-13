using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MakeYourFortune.Model
{
    public class FortuneItem: INotifyPropertyChanged
    {
 
        public int FortuneId { get; set; }
        public string FortuneText;
        public string FortuneCategory;

        public FortuneItem()
        {
            //placeholder
        }
        
        public FortuneItem(string FortuneText, string FortuneCategory)
        {
            this.FortuneText = FortuneText;
            this.FortuneCategory = FortuneCategory;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
