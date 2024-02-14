using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Repository
{
   public interface  INotificationService
    {
        void NotifyUserAdded(User user);
        void NotifyUserUpdated(User user);
        void NotifyUserRemoved(User user);
    }
}
