using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf.view
{
    public partial class reminderView
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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

        public string _name;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }

        public DateTime _full_time;

        public DateTime full_time
        {
            get
            {
                return _full_time;
            }
            set
            {
                _full_time = value;
                OnPropertyChanged("full_time");
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
   
    }
}
