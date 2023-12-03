using AdvanceSolutionpart1.Pages.Components.HomePageComponents;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.AssertionHelpers
{
    public class ProfileAboutMeAssertion
    {
        ProfileAboutMeComponent profileAboutMeComponent = new ProfileAboutMeComponent();

        public void AssertAboutMe(string expectedAvailabilityType, string expectedHours, string expectedTarget)
        {
            Thread.Sleep(2000);
            string availabilityType = profileAboutMeComponent.GetAvailabilityType();
            string hours = profileAboutMeComponent.GetNumberOfHours();
            string target = profileAboutMeComponent.GetTarget();
            Assert.That(availabilityType == expectedAvailabilityType, "Availability type not updated successfully");
            Assert.That(hours == expectedHours, "Hours not updated successfully");
            Assert.That(target == expectedTarget, "Target not updated successfully");
        }
    }
}
