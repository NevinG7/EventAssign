using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1._1
{
  
    public class UserChangedEventArgs : EventArgs
    {
        public User User { get; }
        public string Action { get; }

        public UserChangedEventArgs(User user, string action)
        {
            User = user;
            Action = action;
        }
    }
    public class UserRepository
    {
        private readonly List<User> _users = new();
        public event EventHandler<UserChangedEventArgs> OnUserChanged;

        public User GetUserById(int id)
        {
            return _users.Find(u => u.Id == id);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            OnUserChanged?.Invoke(this, new UserChangedEventArgs(user, "Added"));
        }

        public void UpdateUser(User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
                
            if (user == null) 
            {
                Console.WriteLine("No such user");
                return;
            }
                
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Contact = updatedUser.Contact;

            OnUserChanged?.Invoke(this, new UserChangedEventArgs(user, "Updated"));

    }

        public void RemoveUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
                OnUserChanged?.Invoke(this, new UserChangedEventArgs(user, "Removed"));
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

    }
}

