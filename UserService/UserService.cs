using System;
using UserService.Repository;

namespace UserService
{
    public class UserService
    {
        public UserRepository userRepository = new UserRepository();

        // Create notification services
        SMSNotification smsService = new SMSNotification();
        EmailNotification emailService = new EmailNotification();
        PushNotification pushNotificationService = new PushNotification();

        public UserService()
        {
            
            // Subscribe notification services to events
            userRepository.UserAdded += smsService.NotifyUserAdded;
            userRepository.UserAdded += emailService.NotifyUserAdded;
            userRepository.UserAdded += pushNotificationService.NotifyUserAdded;

            userRepository.UserUpdated += smsService.NotifyUserUpdated;
            userRepository.UserUpdated += emailService.NotifyUserUpdated;
            userRepository.UserUpdated += pushNotificationService.NotifyUserUpdated;

            userRepository.UserRemoved += smsService.NotifyUserRemoved;
            userRepository.UserRemoved += emailService.NotifyUserRemoved;
            userRepository.UserRemoved += pushNotificationService.NotifyUserRemoved;
        }

       

        public void AddUser(User user)
        {
            userRepository.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUserProperty(user.Id, u =>
            {
               
                u.Name = user.Name;
                u.Email = user.Email;
                u.Contact = user.Contact;
            });
        }

        public void RemoveUser(int id)
        {
            userRepository.RemoveUser(id);
        }

       
    }
}