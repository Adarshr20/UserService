using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Repository
{
    public class EmailNotification
    {
        public void NotifyUserAdded(object sender, User user)
        {
            Console.WriteLine($"EmailService: User Added - {user.Id}: {user.Name}");
        }

        public void NotifyUserUpdated(object sender, User user)
        {
            Console.WriteLine($"EmailService: User Updated - {user.Id}: {user.Name}");
        }

        public void NotifyUserRemoved(object sender, User user)
        {
            Console.WriteLine($"EmailService: User Removed - {user.Id}: {user.Name}");
        }
    }
}
