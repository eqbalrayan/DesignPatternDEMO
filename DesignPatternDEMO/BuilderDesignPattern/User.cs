using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.BuilderDesignPattern
{
    public class User
    {
        private string username;
        private string email;
        private string password;

        private User() { }

        public string Username { get { return username; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }

        internal class UserBuilder
        {
            private string username;
            private string email;
            private string password;

            private UserBuilder setUser(string username) {
                this.username = username;

                return this;
            }
            private UserBuilder setEmail( string email)
            {
                this.email = email;  
                return this;
            }
            private UserBuilder setPassword(string password)
            {
                this.password= password;
                return this;
            }

            public User build()
            {
                return new User();
            }

        }
    }
}
