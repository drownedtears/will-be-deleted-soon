using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using bll;
using wpf.view;

namespace wpf.ViewModel
{
    public partial class AddTaskViewModel : INotifyPropertyChanged
    {
        IDbCrud db;

        List<userModel> users = new List<userModel>();
        List<groupModel> groups = new List<groupModel>();
        List<statModel> stats = new List<statModel>();
        List<taskModel> tasks = new List<taskModel>();
        List<reminderModel> reminders = new List<reminderModel>();

        public DelegateCommand delegateCommandOk { get; }

        public AddTaskViewModel()
        {
            delegateCommandOk = new DelegateCommand(Handler);
        }

        public void pinDb(IDbCrud db)
        {
            this.db = db;
            loadData();
        }

        public void Handler()
        {
            int a = 1;
        }

        public void loadData()
        {
            IsCasual = true;
            IsDeadLined = false;
            IsLooped = false;

            users = db.getAllUsers();
            groups = db.getAllGroups();
            stats = db.getAllStats();
            reminders = db.getAllReminders();
            tasks = db.getAllTasks();

            _dataGroup = new ObservableCollection<groupView>();

            for (int i = 0; i < groups.Count; i++)
            {
                groupView a = new groupView();
                a.group_id = groups[i].id;
                a.name = groups[i].name;
                a.user_id = groups[i].user_id;
                a.content_text = groups[i].content_text;
                a.color = groups[i].color;
                _dataGroup.Add(a);
            }

            _dataReminder = new ObservableCollection<reminderView>();

            for (int i = 0; i < reminders.Count; i++)
            {
                reminderView a = new reminderView();
                a.reminder_id = reminders[i].id;
                a.name = reminders[i].name;
                a.user_id = reminders[i].user_id;
                a.content_text = reminders[i].content_text;
                a.full_time = reminders[i].full_time;
                _dataReminder.Add(a);
            }
        }

        public void changeFields(string type)
        {
            if (type == "Обычная")
            {
                IsCasual = true;
                IsDeadLined = false;
                IsLooped = false;
            } 
            else if (type == "С сроком")
            {
                IsCasual = false;
                IsDeadLined = true;
                IsLooped = false;
            }
            else
            {
                IsCasual = false;
                IsDeadLined = false;
                IsLooped = true;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ObservableCollection<groupView> _dataGroup;

        public ObservableCollection<groupView> DataGroup
        {
            get
            {
                return _dataGroup;
            }
            set
            {
                _dataGroup = value;
                OnPropertyChanged("DataGroup");
            }
        }

        public ObservableCollection<reminderView> _dataReminder;

        public ObservableCollection<reminderView> DataReminder
        {
            get
            {
                return _dataReminder;
            }
            set
            {
                _dataReminder = value;
                OnPropertyChanged("DataReminder");
            }
        }

        public bool _is_casual;

        public bool IsCasual
        {
            get
            {
                return _is_casual;
            }
            set
            {
                _is_casual = value;
                OnPropertyChanged("IsCasual");
            }
        }

        public bool _is_dead_lined;

        public bool IsDeadLined
        {
            get
            {
                return _is_dead_lined;
            }
            set
            {
                _is_dead_lined = value;
                OnPropertyChanged("IsDeadLined");
            }
        }

        public bool _is_looped;

        public bool IsLooped
        {
            get
            {
                return _is_looped;
            }
            set
            {
                _is_looped = value;
                OnPropertyChanged("IsLooped");
            }
        }

        public string _choosed_type;

        public string ChoosedType
        {
            get
            {
                return _choosed_type;
            }
            set
            {
                _choosed_type = value;
                changeFields(_choosed_type);
                OnPropertyChanged("ChoosedType");
            }
        }
    }
}
