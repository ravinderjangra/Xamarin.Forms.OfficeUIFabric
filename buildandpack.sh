# From: https://github.com/twilio/TwilioChatXamarinBindings/blob/master/Twilio.Chat/nugetBuildAndPack.sh 
#!/bin/bash -e 
# to be able to build you need installed:
# 1) xamarin itself
# 2) gradle
# 3) xcode and command line tools 
# 4) cocoapods
# 5) sharpie 

# clean
rm -f *.nupkg

# clean android build
MSBuild OfficeUIFabric.Android/OfficeUIFabric.Android.csproj /t:Clean /p:Configuration=Debug
MSBuild OfficeUIFabric.Android/OfficeUIFabric.Android.csproj /t:Clean /p:Configuration=Release
cd OfficeUIFabric.Android
gradle clean
rm -rf bin
cd -

# clean ios build
MSBuild OfficeUIFabric.iOS/OfficeUIFabric.iOS.csproj /t:Clean /p:Configuration=Debug
MSBuild OfficeUIFabric.iOS/OfficeUIFabric.iOS.csproj /t:Clean /p:Configuration=Release
cd OfficeUIFabric.iOS
rm -rf Pods
rm -rf Binding
rm -rf bin
cd -

# fetch artifacts for android 
cd OfficeUIFabric.Android
gradle fetch
cd -

# fetch artifacts for ios
cd OfficeUIFabric.iOS
pod repo update
pod install
cd -

# build android project
MSBuild OfficeUIFabric.Android/OfficeUIFabric.Android.csproj  /p:Configuration=Debug
MSBuild OfficeUIFabric.Android/OfficeUIFabric.Android.csproj  /p:Configuration=Release

# build ios project
cd OfficeUIFabric.iOS
sharpie pod bind
cd -
MSBuild OfficeUIFabric.iOS/OfficeUIFabric.iOS.csproj  /p:Configuration=Debug
MSBuild OfficeUIFabric.iOS/OfficeUIFabric.iOS.csproj  /p:Configuration=Release

# package for nuget
nuget pack nuget/Xamarin.iOS.FabricComponents.nuspec -Verbosity detailed
nuget pack nuget/Xamarin.Android.FabricComponents.nuspec -Verbosity detailed
nuget pack nuget/Xamarin.Forms.Visual.Fabric.nuspec -Verbosity detailed
