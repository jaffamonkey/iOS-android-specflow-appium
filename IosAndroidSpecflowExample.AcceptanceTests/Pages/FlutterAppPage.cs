using IosAndroidSpecflowExample.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SeleniumExtras.PageObjects;
using System;

namespace IosAndroidSpecflowExample.Pages
{
#pragma warning disable 0649
    public class FlutterAppPage : BasePage
    {
        /*[FindsByAndroidUIAutomator(XPath = "//android.widget.Button[@content-desc='Increment']")]*/
        /*[FindsByAndroidUIAutomator(ID = "Increment")]*/
        [FindsByAndroidUIAutomator(ClassName = "android.widget.Button")]
        /*        [FindsByIOSUIAutomation(ID = "Increment")]   */
        private IMobileElement<AppiumWebElement> _increaseCounter;

        [FindsByAndroidUIAutomator(XPath = "//android.widget.Button[@content-desc='Increment']")]
        /*        [FindsByAndroidUIAutomator(ID = "Increment")]
                 [FindsByAndroidUIAutomator(ClassName = "//android.widget.Button[@content-desc='Increment']")]
                [FindsByIOSUIAutomation(ID = "Increment")]   */
        private IMobileElement<AppiumWebElement> _clickPageTwoLink;

        [FindsByAndroidUIAutomator(XPath = "//android.view.View[@content-desc='Counter App Home Page']")]
        /* [FindsByAndroidUIAutomator(ID = "Counter App Home Page")]
              [FindsByAndroidUIAutomator(ClassName = "//android.widget.Button[@content-desc='Increment']")] */
        [FindsByIOSUIAutomation(ID = "Increment")]
        private IMobileElement<AppiumWebElement> _pageTitle;

        [FindsByAndroidUIAutomator(XPath = "//android.view.View[@content-desc='0']")]
        /*      [FindsByAndroidUIAutomator(ID = "//android.widget.Button[@content-desc='Increment']")]
                [FindsByAndroidUIAutomator(XPath = "//android.widget.Button[@content-desc='Increment']")]*/
        [FindsByIOSUIAutomation(ID = "Increment")]
        private IMobileElement<AppiumWebElement> _counterNumber;

        [FindsByAndroidUIAutomator(XPath = "//android.view.View[@content-desc='Contents of page 2']")]
        /*      [FindsByAndroidUIAutomator(ID = 'Contents of page 2')]
                [FindsByAndroidUIAutomator(XPath = "//android.widget.Button[@content-desc='Increment']")]*/
        [FindsByIOSUIAutomation(ID = "Increment")]
        private IMobileElement<AppiumWebElement> _pageTwoContents;

        public FlutterAppPage()
        {
            PageFactory.InitElements(Driver, this, new AppiumPageObjectMemberDecorator());
        }

        public void TapIncreaseCounter()
        {
            Helper.WaitFor(() => _increaseCounter.Displayed);
            _increaseCounter.Click();
        }

        public void ClickPageTwoLink()
        {
            Helper.WaitFor(() => _clickPageTwoLink.Displayed);
            _clickPageTwoLink.Click();
        }
        
        public void WaitUntilPageLoads()
        {
            Helper.WaitFor(() => _increaseCounter.Displayed);
        }

        public void VerifyContentsOfPageTwo()
        {
            Helper.WaitFor(() => _pageTwoContents.Displayed);
        }

        public void CheckPageTitle()
        {
            Helper.WaitFor(() => _pageTitle.Displayed);
        }

        public void CheckCounterIncreasedToOne()
        {
            Helper.WaitFor(() => _counterNumber.Displayed);
        }

    }
}
