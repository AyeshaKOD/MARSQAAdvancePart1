using AdvanceSolutionpart1.Pages.Components.HomePageComponents.AccountMenuComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.AssertionHelpers
{
    public class NotificationAssertion
    {
        NotificationsComponent notificationComponent = new NotificationsComponent();

        public void AssertShowLessNotifications()
        {
            string expectedLink = notificationComponent.GetShowLessLink();
            Assert.That(expectedLink == "...Show Less", "Notifications not loaded successfully");
        }

        public void AssertLoadMoreNotification()
        {
            string expectedLink = notificationComponent.GetLoadMoreLink();
            Assert.That(expectedLink == "Load More...", "Notifications not loaded successfully");
        }

        public void AssertPopUpMessage()
        {
            string expectedMessage = notificationComponent.RenderPopUpMessage();
            Assert.That(expectedMessage == "Notification updated", "Notification not updated");
        }


        public void AssertSelectAllNotification()
        {
            bool status = notificationComponent.RenderAllCheckBoxes();
            Assert.That(status == true, "Notifications are not selected successfully");
        }

        public void AssertUnSelectAllNotification()
        {
            bool status = notificationComponent.RenderAllCheckBoxes();
            Assert.That(status == false, "Notifications are not unselected successfully");
        }
    }
}

