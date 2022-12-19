using System;
using System.Collections.Generic;
using dal;

namespace bll
{
    public partial class userModel
    {

        public int id { get; set; }

        public string login { get; set; }
        public string password { get; set; }

        public string name { get; set; }

        public userModel() { }

        public userModel(User user)
        {
            this.id = user.user_id;
            this.login = user.login;
            this.password = user.password;
            this.name = user.name;
        }

    }
}
