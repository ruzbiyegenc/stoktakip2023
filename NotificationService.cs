using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationService : INotificationService
    {
        private int notificationCount = 0;

        public int GetNotificationCountAccepted()
        {
            var date = DateTime.Now;
            using (var c = new Context())
            {
                notificationCount = c.StockAssignments.Where(x => x.IsAccepted && x.ReturnDate<=date).Count();
            }
            return notificationCount;
        }

        public int GetNotificationCountWait()
        {
            using (var c = new Context())
            {
                notificationCount = c.StockAssignments.Where(x => x.IsAccepted==false).Count();
            }
            return notificationCount;
        }

        // Bildirim sayısını güncellemek için bir metot ekleyebilirsiniz.
        /* public void UpdateNotificationCount(int count)
         {
             notificationCount = count;
         }*/
    }
}
