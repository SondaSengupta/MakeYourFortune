using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeYourFortune.Model;
using System.Data.Entity;

namespace MakeYourFortune
{
    public class FortuneContext: DbContext
    {
        public DbSet<FortuneItem> Fortunes { get; set; }
    }
}
