using System;
using IosAndroidSpecflowExample.Helpers;
using IosAndroidSpecflowExample.Pages;
using TechTalk.SpecFlow;

namespace IosAndroidSpecflowExample.Steps
{
    [Binding]
    public class FlutterAppTest
    {
        [Given(@"I tap increase counter")]
        public void GivenITapIncreaseCounter()
        {
            var flutterAppPage = new FlutterAppPage();

            flutterAppPage.TapIncreaseCounter();
        }

        [Given(@"I check Page Title displayed")]
        public void ICheckPageTitleDisplayed()
        {
            var flutterAppPage = new FlutterAppPage();

            flutterAppPage.CheckPageTitle();
        }

        [Given(@"I check value changes to 1")]
        public void ICheckValueChangesToOne()
        {
            var flutterAppPage = new FlutterAppPage();
            flutterAppPage.CheckCounterIncreasedToOne();
        }

        [Given(@"I click to open page 2")]
        public void IClickToOpenPageTwo()
        {
            var flutterAppPage = new FlutterAppPage();
            flutterAppPage.ClickPageTwoLink();
        }

        [Given(@"I verify contents of Page 2")]
        public void VerifyContentsOfPageTwo()
        {
            var flutterAppPage = new FlutterAppPage();
            flutterAppPage.ClickPageTwoLink();
        }
    }
}
