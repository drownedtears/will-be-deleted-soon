using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class MyTaskRepo : IRepository<MyTask>
    {
        private MyTaskContext db;

        public MyTaskRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<MyTask> GetList()
        {
            return db.tasks.ToList();
        }

        public MyTask GetItem(int id)
        {
            return db.tasks.Find(id);
        }

        public void Create(MyTask item)
        {
            db.tasks.Add(item);
        }

        public void Update(MyTask item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            MyTask item = db.tasks.Find(id);
            if (item != null)
                db.tasks.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
