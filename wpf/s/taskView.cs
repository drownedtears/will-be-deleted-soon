using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf.view
{
    public partial class taskView : INotifyPropertyChanged
    {       

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public int _id;

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("id");
            }
        }

        public string _type;

        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged("type");
            }
        }

        public string _header;

        public string header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
                OnPropertyChanged("header");
            }
        }

        public string _content_text;

        public string content_text
        {
            get
            {
                return _content_text;
            }
            set
            {
                _content_text = value;
                OnPropertyChanged("content_text");
            }
        }

        public string _condition;
        
        public string condition
        {
            get
            {
                return _condition;
            }
            set
            {
                _condition = value;
                OnPropertyChanged("condition");
            }
        }

        public DateTime _cre_date;

        public DateTime cre_date
        {
            get
            {
                return _cre_date;
            }
            set
            {
                _cre_date = value;
                OnPropertyChanged("cre_date");
            }
        }

        public DateTime _finish_date;

        public DateTime finish_date
        {
            get
            {
                return _finish_date;
            }
            set
            {
                _finish_date = value;
                OnPropertyChanged("finish_date");
            }
        }

        public int _user_id;

        public int user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                _user_id = value;
                OnPropertyChanged("user_id");
            }
        }

        public DateTime _dead_line;

        public DateTime dead_line
        {
            get
            {
                return _dead_line;
            }
            set
            {
                _dead_line = value;
                OnPropertyChanged("dead_line");
            }
        }

        public int _days_to_finish;

        public int days_to_finish
        {
            get
            {
                return _days_to_finish;
            }
            set
            {
                _days_to_finish = value;
                OnPropertyChanged("days_to_finish");
            }
        }

        public int _sleep;

        public int sleep
        {
            get
            {
                return _sleep;
            }
            set
            {
                _sleep = value;
                OnPropertyChanged("sleep");
            }
        }

        public int _stat_id;

        public int stat_id
        {
            get
            {
                return _stat_id;
            }
            set
            {
                _stat_id = value;
                OnPropertyChanged("stat_id");
            }
        }

        public int _group_id;

        public int group_id
        {
            get
            {
                return _group_id;
            }
            set
            {
                _group_id = value;
                OnPropertyChanged("group_id");
            }
        }

        public int _reminder_id;

        public int reminder_id
        {
            get
            {
                return _reminder_id;
            }
            set
            {
                _reminder_id = value;
                OnPropertyChanged("reminder_id");
            }
        }

        public DelegateCommand<object> delegateCommand { get; }
        public DelegateCommand<object> delegateCommandMore { get; }

        public taskView()
        {
            delegateCommand = new DelegateCommand<object>(Handler);
            delegateCommandMore = new DelegateCommand<object>(HandlerMore);
        }

        public void Handler(object param)
        {
            object p = param;
        }

        public void HandlerMore(object param)
        {
            object p = param;
        }

    }
}
