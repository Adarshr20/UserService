using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Repository
{
    public class PushNotification
    {
        public void NotifyUserAdded(object sender, User user)
        {
            Console.WriteLine($"PushNotificationService: User Added - {user.Id}: {user.Name}");
        }

        public void NotifyUserUpdated(object sender, User user)
        {
            Console.WriteLine($"PushNotificationService: User Updated - {user.Id}: {user.Name}");
        }

        public void NotifyUserRemoved(object sender, User user)
        {
            Console.WriteLine($"PushNotificationService: User Removed - {user.Id}: {user.Name}");
        }
    }
}
