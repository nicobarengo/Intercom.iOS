# Binding.Intercom

![Nuget](https://img.shields.io/nuget/v/BarengoEngineering.Intercom.iOS)

## Summary

The following binding are for the **Intercom SDK**.

## iOS

Documentation for using the library inside an iOS project can be found [here](https://developers.intercom.com/docs/welcome).

The source for the SDK can be found [here](https://github.com/intercom/intercom-ios). 

The bindings were generated for the version **16.2.1** and requires XCode >= 15.


### How to use


Add the flowing packages to the iOS csproj if you use a Mac with Apple Silicon

```csharp
<PackageReference Include="BarengoEngineering.Intercom.iOS" Version="16.2.1.0" />
```


If you use an Intel Mac add the following packages

```csharp
<PackageReference Condition="'$(Configuration)|$(Platform)' != 'Debug|iPhoneSimulator'" Include="BarengoEngineering.Intercom.iOS" Version="16.2.1.0" />
<PackageReference Condition="'$(Configuration)|$(Platform)' == 'Debug|iPhoneSimulator'" Include="BarengoEngineering.Intercom.iOS.Simulator" Version="16.2.1.0" />
```


Add a reference to the following package:

```csharp
using BarengoEngineering.Intercom;
```

Clean, restore nuget packages and Build for every change of Run configuration to remove Intercom Simulator/Device binaries

If you encounter issues building, deploying or running add this to the csproj

```csharp
<Registrar>static</Registrar>
```


### Update Info.plist


When installing Intercom, you'll need to make sure that you have a `NSPhotoLibraryUsageDescription` entry in your `Info.plist`.

This is [required by Apple](https://developer.apple.com/library/content/qa/qa1937/_index.html) for all apps that access the photo library. It is necessary when installing Intercom due to the image upload functionality. Users will be prompted for the photo library permission only when they tap the image upload button.

## Breaking Changes

Please consult [BREAKING_CHANGES.md](BREAKING_CHANGES.md) for more information about migration.
