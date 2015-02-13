using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeYourFortune.Model;

namespace MakeYourFortune.Repository
{
    public interface IFortuneRepository
    {
        int GetCount();
        void Add(FortuneItem F); 
        void Delete(FortuneItem F); 
        void Clear();
        void Dispose();
    }
}
