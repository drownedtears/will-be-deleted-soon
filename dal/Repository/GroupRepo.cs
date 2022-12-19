using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class GroupRepo : IRepository<Group>
    {
        private MyTaskContext db;

        public GroupRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Group> GetList()
        {
            return db.groups.ToList();
        }

        public Group GetItem(int id)
        {
            return db.groups.Find(id);
        }

        public void Create(Group item)
        {
            db.groups.Add(item);
        }

        public void Update(Group item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Group item = db.groups.Find(id);
            if (item != null)
                db.groups.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
