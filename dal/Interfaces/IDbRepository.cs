using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public interface IDbRepository
    {
        IRepository<User> users { get; }
        IRepository<Group> groups { get; }
        IRepository<Stat> stats { get; }
        IRepository<MyTask> tasks { get; }
        IRepository<Reminder> reminders { get; }
        IRepository<Activity> activities { get; }
        int Save();
    }
}
