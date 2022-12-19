using dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class ReminderRepo : IRepository<Reminder>
    {
        private MyTaskContext db;

        public ReminderRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Reminder> GetList()
        {
            return db.reminders.ToList();
        }

        public Reminder GetItem(int id)
        {
            return db.reminders.Find(id);
        }

        public void Create(Reminder item)
        {
            db.reminders.Add(item);
        }

        public void Update(Reminder item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Reminder item = db.reminders.Find(id);
            if (item != null)
                db.reminders.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
