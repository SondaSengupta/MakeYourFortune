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
        private IQueryable<Model.FortuneItem> query;

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
            return _dbContext.Fortunes.Count<Model.FortuneItem>();
        }

        public void Add(Model.FortuneItem F)
        {
            _dbContext.Fortunes.Add(F);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.FortuneItem F)
        {
            _dbContext.Fortunes.Remove(F);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var allItemsQuery = from Event in _dbContext.Fortunes select Event;
            var a = allItemsQuery.ToList<Model.FortuneItem>();
            _dbContext.Fortunes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public string GetByCategory(string category)
        {
            var queryied = QueryByCategory(category);
            if (!queryied.Any())
            {
                return "Sorry, no fortunes in this cookie jar today. Add one to nom on the wisdom later!";
            }
            return GetRandomFortune(queryied);
        }

        private IQueryable<Model.FortuneItem> QueryByCategory(string category)
        {
          
            if (category == "Life")
            {
               query = from Fortunes in _dbContext.Fortunes
                            select Fortunes;
                return query;
            }
            query = from Fortunes in _dbContext.Fortunes
                        where Fortunes.FortuneCategory == category
                        select Fortunes;
            return query;
        }

        private static string GetRandomFortune(IQueryable<Model.FortuneItem> queryied)
        {
            Random number = new Random();
            var queryList = queryied.ToList();
            int num = number.Next(queryList.Count());
            return queryList.ElementAt(num).FortuneText;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
