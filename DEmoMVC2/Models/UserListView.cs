
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserDbModel;

namespace DEmoMVC2.Models
{
    public class UserListView
    {

        public string Title { get; set; }

        public List<User> Users { get; set; }

        public int Pages { get; set; }
    }
}