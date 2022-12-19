using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class UserRepo : IRepository<User>
    {
        private MyTaskContext db;

        public UserRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<User> GetList()
        {
            return db.users.ToList();
        }

        public User GetItem(int id)
        {
            return db.users.Find(id);
        }

        public void Create(User item)
        {
            db.users.Add(item);
        }

        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User item = db.users.Find(id);
            if (item != null)
                db.users.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
