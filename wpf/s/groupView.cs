using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf.view
{
    public partial class groupView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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

        public string _color;

        public string color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged("color");
            }
        }
    }
}
