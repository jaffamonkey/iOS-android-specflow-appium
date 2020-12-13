using System;
using IosAndroidSpecflowExample.Helpers;
using IosAndroidSpecflowExample.Pages;
using TechTalk.SpecFlow;

namespace IosAndroidSpecflowExample.Steps
{
    [Binding]
    public class FlutterAppTest
    {
        [Given(@"I tap Accessibility link")]
        public void GivenITapAccessibilityLink()
        {
            var addAcquaintancePage = new AddAcquaintancePage();

            addAcquaintancePage.TapOnAccessibilityLink();
        }
    }
}
