using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeYourFortune.Model
{
    public class FortuneItem
    {
        public string FortuneText;
        public string FortuneCategory;

        public FortuneItem(string FortuneText, string FortuneCategory)
        {
            this.FortuneText = FortuneText;
            this.FortuneCategory = FortuneCategory;
        }
    }
}
