using bll;
using GalaSoft.MvvmLight.Command;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using wpf.view;
using dal;

namespace wpf.ViewModel
{
    public partial class MainWindowViewModel : INotifyPropertyChanged
    {
        IDbCrud db;

        List<userModel> users = new List<userModel>();
        List<groupModel> groups = new List<groupModel>();
        List<statModel> stats = new List<statModel>();
        List<taskModel> tasks = new List<taskModel>();
        List<reminderModel> reminders = new List<reminderModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand delegateCommandMain { get; }


        public MainWindowViewModel()
        {
            db = new Dao(new DbReposSQL());
            delegateCommandMain = new DelegateCommand(Handler);
            loadData();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        private void Handler()
        {
            AddTask addTask = new AddTask();

            AddTaskViewModel addTaskVM = new AddTaskViewModel();
            addTaskVM.pinDb(db);
            addTask.DataContext = addTaskVM;

            addTask.ShowDialog();
        }

        public void loadData()
        {
            users = db.getAllUsers();
            groups = db.getAllGroups();
            stats = db.getAllStats();
            reminders = db.getAllReminders();
            tasks = db.getAllTasks();
            DataTask = new ObservableCollection<taskView>();

            for (int i = 0; i < tasks.Count; i++)
            {
                taskView a = new taskView();
                a.id = tasks[i].id;
                a.type = tasks[i].type;
                a.header = tasks[i].header;
                a.content_text = tasks[i].content_text;
                a.condition = tasks[i].condition;
                a.cre_date = tasks[i].cre_date;
                a.finish_date = tasks[i].finish_date;
                a.user_id = tasks[i].user_id;
                a.dead_line = tasks[i].dead_line;
                a.days_to_finish = tasks[i].days_to_finish;
                a.sleep = tasks[i].sleep;
                a.stat_id = tasks[i].stat_id;
                a.group_id = tasks[i].group_id;
                DataTask.Add(a);
            }
        } 

        public ObservableCollection<taskView> _dataTask;

        public ObservableCollection<taskView> DataTask
        {
            get
            {
                return _dataTask;
            }
            set
            {
                _dataTask = value;
                OnPropertyChanged("DataTask");
            }
        } 
    }
}
