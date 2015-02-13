using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MakeYourFortune.Repository
{
    public class FortuneRepository: IFortuneRepository
    {
        private FortuneContext _dbContext;  //declares db field

        public FortuneRepository()
        {
            _dbContext = new FortuneContext(); //generates new instance of FortuneContext
            _dbContext.Fortunes.Load();  //Loads the DbSet Fortunes, which connects the database to dbLogic
        }
        public FortuneContext Context()
        {
            return _dbContext;
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.FortuneItem F)
        {
            throw new NotImplementedException();
        }

        public void Delete(int FortuneId)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            var allItemsQuery = from Event in _dbContext.Fortunes select Event;
            var a = allItemsQuery.ToList<Model.FortuneItem>();
            _dbContext.Fortunes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
