# Binding.Intercom

![Nuget](https://img.shields.io/nuget/v/BarengoEngineering.Intercom.iOS)

## Summary

The following binding are for the **Intercom SDK**.

## iOS

Documentation for using the library inside an iOS project can be found [here](https://developers.intercom.com/docs/welcome).

The source for the SDK can be found [here](https://github.com/intercom/intercom-ios). 

The bindings were generated for the version **15.1.5**.

To upgrade to v9.0.0 please [follow the migration guide](https://developers.intercom.com/installing-intercom/docs/migrating-to-v9).

### How to use

Add the flowing packages to the iOS csproj

```csharp
<PackageReference Condition="'$(Configuration)|$(Platform)' != 'Debug|iPhoneSimulator'" Include="BarengoEngineering.Intercom.iOS" Version="15.1.5.3" />
<PackageReference Condition="'$(Configuration)|$(Platform)' == 'Debug|iPhoneSimulator'" Include="BarengoEngineering.Intercom.iOS.Simulator" Version="15.1.5.3" />
```


Add a reference to the following package:

```csharp
using BarengoEngineering.Intercom;
``

Clean, restore nuget packages and Build for every change of Run configuration to remove Intercom Simulator/Device binaries


### Update Info.plist


When installing Intercom, you'll need to make sure that you have a `NSPhotoLibraryUsageDescription` entry in your `Info.plist`.

This is [required by Apple](https://developer.apple.com/library/content/qa/qa1937/_index.html) for all apps that access the photo library. It is necessary when installing Intercom due to the image upload functionality. Users will be prompted for the photo library permission only when they tap the image upload button.

## Breaking Changes

Please consult [BREAKING_CHANGES.md](BREAKING_CHANGES.md) for more information about migration.
