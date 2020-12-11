# To run tests locally:

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

Not priority for this POC, as primary focus in on testing framework and tools in context of Browserstack

I have not included local reports for POC, as browserstack will generate those (they are extensive).
When running tests locally, and there is an error a screenshot is created and located in default project build directory.
