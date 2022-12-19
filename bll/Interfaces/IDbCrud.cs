using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public interface IDbCrud
    {
        List<taskModel> getAllTasks();
        List<statModel> getAllStats();
        List<userModel> getAllUsers();
        List<groupModel> getAllGroups();
        List<reminderModel> getAllReminders();
        taskModel getTask(int id);
        groupModel getGroup(int id);
        reminderModel getReminder(int id);
        void createTask(taskModel a);
        void createGroup(groupModel a);
        void createReminder(reminderModel a);
        void updateTask(taskModel deal);
        void updateGroup(groupModel deal);
        void updateReminder(reminderModel deal);
        void deleteTask(int id);
        void deleteGroup(int id);
        void deleteReminder(int id);
        bool Save();
    }
}
