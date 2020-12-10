using System.Diagnostics;
using System.IO;
using IosAndroidSpecflowExample.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace IosAndroidSpecflowExample.Steps
{
    [Binding]
    public class Hooks
    {
        public Hooks(ScenarioContext currentScenarioContext)
        {
            CurrentScenarioContext = currentScenarioContext;
        }

        private ScenarioContext CurrentScenarioContext { get; set; }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            AppiumManager.Platform = Settings.GlobalSettings.Platform == "iOS" ? PlatformEnum.IOS : PlatformEnum.Android;
            AppiumServer.OutputDataReceived += OnOutputDataReceived;
            AppiumServer.StartServerIfShouldRunLocally();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            AppiumManager.CloseDriver();
            AppiumServer.StopLocalService();
            AppiumServer.OutputDataReceived -= OnOutputDataReceived;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            TestLogger.CurrentTextWriter = TestContext.Progress;

            AppiumManager.ResetApp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (CurrentScenarioContext.TestError != null)
            {
                try
                {
                    var screenshot = AppiumManager.Driver.GetScreenshot();
                    string screenshotPath = Path.Combine(TestContext.CurrentContext.WorkDirectory, $"{TestContext.CurrentContext.Test.Name}.png");
                    File.WriteAllBytes(screenshotPath, screenshot.AsByteArray);

                    TestContext.AddTestAttachment(screenshotPath);
                }
                catch
                {
                    if (AppiumManager.Platform == PlatformEnum.IOS)
                    {
                        AppiumManager.CreateDriver();
                    }
                }
            }
        }

        private static void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            TestLogger.WriteLineToConsoleOutput(e.Data);
            TestLogger.WriteLineToTestOutput(e.Data);
        }
    }
}
