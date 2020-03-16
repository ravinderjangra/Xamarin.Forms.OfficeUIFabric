#load "common.cake"

var TARGET = Argument ("t", Argument ("target", "Default"));

var IOS_PODS = new List<string> {
	"platform :ios, '11.4'",
	"install! 'cocoapods', :integrate_targets => false",
	"use_frameworks!",
	"target 'Xamarin' do",
	"pod 'OfficeUIFabric', '1.0.6'",
	"end",
};

var buildSpec = new BuildSpec {

	Libs = new ISolutionBuilder [] {
		new IOSSolutionBuilder {
			SolutionPath = "../OfficeUIFabric.iOS/OfficeUIFabric.iOS.csproj",
			Configuration = "Release",
			Platform = "Any CPU",
			OutputFiles = new [] { 
				new OutputFileCopy {
					FromFile = "./OfficeUIFabric.iOS/OfficeUIFabric.iOS/bin/Release/OfficeUIFabric.iOS.dll",
				}
			}
		},
	},
};

Task ("externals").IsDependentOn ("externals-base")
	.WithCriteria (!FileExists ("./externals/libMaterialComponents.a"))
	.Does (() => 
{
	EnsureDirectoryExists ("./externals");

	if (CocoaPodVersion () < new System.Version (1, 0))
		IOS_PODS.RemoveAt (1);

	FileWriteLines ("./externals/Podfile", IOS_PODS.ToArray ());

	CocoaPodInstall ("./externals");

	BuildDynamicXCode ("./Pods/Pods.xcodeproj", "OfficeUIFabric", "OfficeUIFabric", "./externals/", TargetOS.iOS);
});

Task ("clean").IsDependentOn ("clean-base").Does (() => 
{
	if (DirectoryExists ("./externals/"))
		DeleteDirectory ("./externals/", true);
});

SetupXamarinBuildTasks (buildSpec, Tasks, Task);

RunTarget (TARGET);
