using AdvanceSolutionpart1.Pages.Components.HomePageComponents.AccountMenuComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Steps
{
    public class NotificationSteps
    {
        NotificationsComponent notificationComponent;

        public NotificationSteps()
        {
            notificationComponent = new NotificationsComponent();

        }

        public void LoadMoreNotification()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.ClickOnLoadMoreLink();
        }

        public void ShowLessNotification()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.ClickOnShowLessLink();
        }

        public void DeleteNotification()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.DeleteSelectedNotification();
        }

        public void MarkNotificationAsRead()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.MarkSelectedNotificationASRead();
        }

        public void SelectNotification()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.SelectAllNotification();
        }

        public void UnSelectNotification()
        {
            notificationComponent.GoToNotifications();
            notificationComponent.UnSelectAllNotification();
        }
    }
}
