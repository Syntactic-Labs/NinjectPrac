using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPrac
{
    class User
    {
        private INotificationService _notificationService;
        public string Name { get; set; }

        public User(string username, INotificationService notificationService)
        {
            this.Name = username;
            _notificationService = notificationService;
        }

        public void ChangeUsername(string newUsername)
        {
            this.Name = newUsername;
            _notificationService.NotifyUsernameChanged(this);
        }
    }
}
