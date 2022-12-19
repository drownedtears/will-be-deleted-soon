using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class ActivityRepo : IRepository<Activity>
    {
        private MyTaskContext db;

        public ActivityRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Activity> GetList()
        {
            return db.activities.ToList();
        }

        public Activity GetItem(int id)
        {
            return db.activities.Find(id);
        }

        public void Create(Activity item)
        {
            db.activities.Add(item);
        }

        public void Update(Activity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Activity item = db.activities.Find(id);
            if (item != null)
                db.activities.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
