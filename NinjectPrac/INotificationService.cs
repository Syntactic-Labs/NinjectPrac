using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectPrac
{
    interface INotificationService
    {
        void NotifyUsernameChanged(User user);
    }
}
