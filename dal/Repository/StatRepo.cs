using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class StatRepo : IRepository<Stat>
    {
        private MyTaskContext db;

        public StatRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Stat> GetList()
        {
            return db.stats.ToList();
        }

        public Stat GetItem(int id)
        {
            return db.stats.Find(id);
        }

        public void Create(Stat item)
        {
            db.stats.Add(item);
        }

        public void Update(Stat item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Stat item = db.stats.Find(id);
            if (item != null)
                db.stats.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
