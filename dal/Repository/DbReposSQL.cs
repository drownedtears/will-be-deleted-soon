using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class DbReposSQL : IDbRepository
    {
        private MyTaskContext db;
        private UserRepo userRepository;
        private GroupRepo groupRepository;
        private StatRepo statRepository;
        private MyTaskRepo taskRepository;
        private ReminderRepo reminderRepository;
        private ActivityRepo activityRepository;
        //private reportsRepo reportsRepo;

        public DbReposSQL()
        {
            db = new MyTaskContext();
        }

        public IRepository<User> users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepo(db);
                return userRepository;
            }
        }

        public IRepository<MyTask> tasks
        {
            get
            {
                if (taskRepository == null)
                    taskRepository = new MyTaskRepo(db);
                return taskRepository;
            }
        }

        public IRepository<Group> groups
        {
            get
            {
                if (groupRepository == null)
                    groupRepository = new GroupRepo(db);
                return groupRepository;
            }
        }

        public IRepository<Stat> stats
        {
            get
            {
                if (statRepository == null)
                    statRepository = new StatRepo(db);
                return statRepository;
            }
        }

        public IRepository<Reminder> reminders
        {
            get
            {
                if (reminderRepository == null)
                    reminderRepository = new ReminderRepo(db);
                return reminderRepository;
            }
        }

        public IRepository<Activity> activities
        {
            get
            {
                if (activityRepository == null)
                    activityRepository = new ActivityRepo(db);
                return activityRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
