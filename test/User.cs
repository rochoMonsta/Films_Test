using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class User
    {
        public static User currentUser;
        public string Login { get; set; }
        public string Password { get; set; }
        internal List<Film> Films { get => films; set => films = value; }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public User() { }
        private List<Film> films = new List<Film>();
        public override string ToString()
        {
            return $"{Login} - {Password}";
        }
    }
}
