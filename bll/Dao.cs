using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using dal;
using bll;

namespace bll
{
    public partial class Dao : IDbCrud
    {
        IDbRepository db;
        public Dao(IDbRepository repo)
        {
            db = repo;
        }

        public List<taskModel> getAllTasks()
        {
            return db.tasks.GetList().Select(i => new taskModel(i))
                .OrderBy(i => i.cre_date)
                .ToList();
        }

        public List<groupModel> getAllGroups()
        {
            return db.groups.GetList().Select(i => new groupModel(i)).ToList();
        }

        public List<reminderModel> getAllReminders()
        {
            return db.reminders.GetList().Select(i => new reminderModel(i)).ToList();
        }

        public List<userModel> getAllUsers()
        {
            return db.users.GetList().Select(i => new userModel(i)).ToList();
        }

        public List<statModel> getAllStats()
        {
            return db.stats.GetList().Select(i => new statModel(i)).ToList();
        }


        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        public void createTask(taskModel a)
        {
            db.tasks.Create(new MyTask()
            {
                task_id = a.id,
                type = a.type,
                header = a.header,
                content_text = a.content_text,
                condition = a.condition,
                cre_date = a.cre_date,
                finish_date = a.finish_date,
                user_id = a.user_id,
                dead_line = a.dead_line,
                days_to_finish = a.days_to_finish,
                sleep = a.sleep,
                stat_id = a.stat_id,
                group_id = a.group_id
            });            
            Save();
        }

        public void createGroup(groupModel a)
        {
            db.groups.Create(new Group()
            {
                group_id = a.id,
                name = a.name,
                content_text = a.content_text,
                color = a.color,
                user_id = a.user_id
            });
            Save();
        }

        public void createActivity(activityModel a)
        {
            db.activities.Create(new Activity()
            {
                activity_id = a.activity_id,
                task_name = a.task_name,
                finish_date = a.finish_date,
                user_id = a.user_id,
                event_name = a.event_name
            });
            Save();
        }

        public void createReminder(reminderModel a)
        {
            db.reminders.Create(new Reminder()
            {
                reminder_id = a.id,
                content_text = a.content_text,
                full_time = a.full_time,
                user_id = a.user_id
            });
            Save();
        }

        public void updateTask(taskModel a)
        {
            MyTask o = db.tasks.GetItem(a.id);
            o.task_id = a.id;
            o.type = a.type;
            o.header = a.header;
            o.content_text = a.content_text;
            o.condition = a.condition;
            o.cre_date = a.cre_date;
            o.finish_date = a.finish_date;
            o.user_id = a.user_id;
            o.dead_line = a.dead_line;
            o.days_to_finish = a.days_to_finish;
            o.sleep = a.sleep;
            o.stat_id = a.stat_id;
            db.tasks.Update(o);
            Save();
        }

        public void updateActivity(activityModel a)
        {
            Activity o = db.activities.GetItem(a.activity_id);
            o.task_name = a.task_name;
            o.user_id = a.user_id;
            o.event_name = a.event_name;
            o.finish_date = a.finish_date;   
            db.activities.Update(o);
            Save();
        }

        public void updateGroup(groupModel a)
        {
            Group o = db.groups.GetItem(a.id);
            o.group_id = a.id;
            o.name = a.name;
            o.color = a.color;
            o.content_text = a.content_text;
            o.user_id = a.user_id;
            db.groups.Update(o);
            Save();
        }

        public void updateReminder(reminderModel a)
        {
            Reminder o = db.reminders.GetItem(a.id);
            o.reminder_id = a.id;
            o.full_time = a.full_time;
            o.content_text = a.content_text;
            o.user_id = a.user_id;
            db.reminders.Update(o);
            Save();
        }


        public void deleteTask(int id)
        {
            MyTask a = db.tasks.GetItem(id);
            if (a != null)
            {
                db.tasks.Delete(id);
                Save();
            }
        }

        public void deleteGroup(int id)
        {
            Group a = db.groups.GetItem(id);
            if (a != null)
            {
                db.groups.Delete(id);
                Save();
            }
        }

        public void deleteReminder(int id)
        {
            Reminder a = db.reminders.GetItem(id);
            if (a != null)
            {
                db.reminders.Delete(id);
                Save();
            }
        }

        public taskModel getTask(int id)
        {
            return new taskModel(db.tasks.GetItem(id));
        }

        public groupModel getGroup(int id)
        {
            return new groupModel(db.groups.GetItem(id));
        }

        public reminderModel getReminder(int id)
        {
            return new reminderModel(db.reminders.GetItem(id));
        }

        public activityModel getActivity(int user_id)
        {
            List<activityModel> l = db.activities.GetList().Select(i => new activityModel(i)).ToList();
            for (int i = 0; i < l.Count; i++)
            {
                if(l[i].user_id == user_id)
                {
                    return l[i];
                }
            }
            return null; //так нельзя но мне лень реализовывать исключение, ловить его и обрабатывать :)
        }
    }
}
