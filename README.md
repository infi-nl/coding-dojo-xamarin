Infi Coding Dojo - Xamarin QuizApp
==================================

This is the basic Xamarin solution for the Coding Dojo held at Infi on July 19th, 2016. The solution contains a basic set of classes to build a simple Xamarin application. A facade to the Quiz API to retrieve quiz questions and check answers has already been implemented and is avaiable for use in the app.


Visual Studio 2015 with Xamarin
=====================================
Follow the link for a tutorial on how to install Visual Studio 2015 with Xamarin for free.
https://msdn.microsoft.com/en-us/library/mt613162.aspx
 - In the dojo we're using the Xamarin version that comes with the Visual Studio 2015 Community Edition (if you already have Xamarin installed, you can update it through visual studio).

Configuring the dojo project
============================
Clone the project.
Restore solutions packages with Nuget.
You should now be able to build the project. If not, see if you can solve the problem by unloading the projects belonging to the platforms you're not going  to use (e.g. Windows Phone)

 - If  you're getting errors in the android project
    - Make sure the project settings are configured correctly (android project -> properties -> application)
        - Compile using Android version: Use Latest Platform
        - Minimum Android to target version: Android 4.0.3 (API Level 15)
        - Target Android version: Use Comppile using SDK version
    - Make sure all packages are installed correctly through Nuget.

Android
=======
After installing Visual Studio with Xamarin, you should be able to navigate in VS
    Tools -> Android -> Android SDK Manager
In the SDK manager install everything from the directory of the SDK version you're planning on using.
The dojo project supports android versions newer than Android API 15 (4.0), so the SDK you're installing should be at least that.
If you want to use your physical smartphone to deploy the app on, make sure you're installing the SDK version that corresponds with the Android version on  your phone.
If you prefer using an emulator to deploy the app on, we suggest you download the SDK for API 21 (Android 5.0.1) as  this is the one we used most for testing.

Deploying the app onto your phone
---------------------------------
Make sure you
   - have installed the SDK version that corresponds with the Android version on your phone.
   - have enabled development mode on your phone (by tapping your phone's build number on the Settings on your phone in most cases)
   - have installed Google USB drivers in the Android SKD manager (listed under the extra's directory).
   - granted permission on your phone to connect to your computer after plugging it in.
Your phone should now appear in Visual Studio as a deployment option (after you have selected the Android project as the startup project)
If you're having trouble, try rebooting Visual Studio or your computer.

Deploying the app onto an emulator
----------------------------------

NOTE: We've added a picture of an example of how we configured our emulator (/docs/emulator-settings.png).

Make sure you
   - created an emulator in Tools -> Android -> Android Device Manager -> Create.
   - have installed the correct SDK version in Tools -> Android -> Android SDK Manager. You can only create an emulator targeting a specific Android version after you have installed the corresponding SDK.
   - have created an emulator that targets an Android version that is at least newer than Android 4.0. We suggest you use Android 5.0.1 (API 21).
   - have installed HAXM (granted you have an Intel processor) and disabled Hyper-V
Your emulator should now appear in Visual Studio as a deployment option (after you have selected the Android project as the startup project)

Installing HAXM
 - https://software.intel.com/en-us/android/articles/intel-hardware-accelerated-execution-manager/
 - Run the setup and not the silent-install.
 Note that HAXM only works on computers that are based on an Intel processor.

Turning off Hyper-V
 - http://www.eightforums.com/tutorials/42041-hyper-v-enable-disable-windows-8-a.html
 - http://www.nextofwindows.com/how-to-enable-configure-and-use-hyper-v-on-windows-10
 Note that disabling Hyper-V might cause other running virtual machines to not work properly anymore.
 You can simply turn on Hyper-V later, though you'll have to find another way to run an Android emulator if disabling Hyper-V is not an option for you.

 --- NOTE ---
 We found that with a default installation of Xamarin there comes a tool called 'Visual Studio Emulator for Android'.
 Though we haven't tested this a lot yet, it might be a good idea to try this tool if the above steps are not working for you.
 This tool allows you to download ready-to-go emulators with a single click, after which you can deploy your app on them.

Finished?
=========
You're ready if you can succesfully deploy the app in this repo on your device or emulator.
When the app boots you should see a nice 'Hello dojo!' greeting.

TROUBLESHOOTING
===============
As the dojo draws closer, you or others may run into problems that are not described here.
In this section we will list problems that have been encountered, with a solution if there exists one.
If you ran into trouble, you can contact us through this meeptup if you can't seem to solve your problem, 
or provide us with your solution to it so that other people may use the fruit of your struggle.

Problems (with their solutions)
 - VS ERROR: Please install package < XXX > available in SDK installer. Java library file < FILEPATH > doesn't exist.
   Solution: Delete all from the path: C:\Users\USERNAME\AppData\Local\Xamarin Folders and Zip files. And then rebuild your project.
   Source  : http://stackoverflow.com/a/37827122
