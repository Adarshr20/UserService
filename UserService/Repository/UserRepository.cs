using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Repository
{
    public class UserRepository
    {
        private List<User> users = new List<User>();
        public event EventHandler<User> UserAdded;
        public event EventHandler<User> UserUpdated;
        public event EventHandler<User> UserRemoved;

      
        public void AddUser(User user)
        {
            users.Add(user);
            OnUserAdded(user);
        }

       
        public void UpdateUserProperty(int userId, Action<User> updateAction)
        {
            var user = users.Find(u => u.Id == userId);
            if (user != null)
            {
                updateAction(user);
                OnUserUpdated(user);
            }
            else
            {
                Console.WriteLine($"User with ID {userId} not found.");
            }
        }

      
        public void RemoveUser(int userId)
        {
            var user = users.Find(u => u.Id == userId);
            if (user != null)
            {
                users.Remove(user);
                OnUserRemoved(user);
            }
            else
            {
                Console.WriteLine($"User with ID {userId} not found.");
            }
        }
       
      


        protected virtual void OnUserAdded(User user)
        {
            UserAdded?.Invoke(this, user);
        }

        protected virtual void OnUserUpdated(User user)
        {
            UserUpdated?.Invoke(this, user);
        }

        protected virtual void OnUserRemoved(User user)
        {
            UserRemoved?.Invoke(this, user);
        }
    }
}
