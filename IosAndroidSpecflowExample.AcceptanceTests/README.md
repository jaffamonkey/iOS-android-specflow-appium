# To run tests locally:

First start Appium and start an emulator (assumed device identifier is `Pixel_XL_API_28`).

Check the `Settings` directory for more configuration options.

### Run from Visual Studio
After building solution, open Test Explorer and run speclfow test from there.

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

I have not included local reports for POC, as browserstack will generate those (they are extensive).
If there is an error a screenshot is created and located in default project build directory.