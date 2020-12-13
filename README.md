# To run tests locally:

*TODO: Browserstack integration*

First start Appium and start an emulator (assumed device identifier is `Pixel_XL_API_28`).

Check the `Settings` directory for more configuration options.

### Run from Visual Studio
After building solution, open Test Explorer and run Specflow tests from there.

### Run from command-line
First, navigate to the project DLL location 
```
$ cd \iOS-android-specflow-appium\IosAndroidSpecflowExample.AcceptanceTests\bin\Debug\netcoreapp3.1
```
Then use the dotnet command

```
dotnet test IosAndroidSpecflowExample.dll
```

### Reports

No report output, as relying on browserstack.  Error screenshots are generated on test failures and storied in the default build dir.
