using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1._1
{
    public interface INotification
    {
        void Notify(string msg);
    }

    public class SmsService : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine($"Sms Noti : {msg}");
        }
    }

    public class EmailService : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine($"Email Noti : {msg}");
        }
    }

    public class PushNotificationService : INotification
    {
        public void Notify(string msg)
        {
            Console.WriteLine($"Push Noti : {msg}");
        }
    }

}
