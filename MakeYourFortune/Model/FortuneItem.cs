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
        
        public int FortuneItemId { get; set; }
        public string FortuneText { get; set; }
        public string FortuneCategory { get; set; }

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