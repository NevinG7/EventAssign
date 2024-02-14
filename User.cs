using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1._1
{
    public class User
    {
        private static int globalId=1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }

        public User(string name, string email, int contact) {
            this.Name = name;
            this.Email = email;
            this.Contact = contact;
            this.Id = globalId++;
        }
    }
}
