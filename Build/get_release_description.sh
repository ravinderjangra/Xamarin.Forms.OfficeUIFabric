read -r -d '' release_description << 'EOF'
Xamarin.Android, Xamarin.iOS bindings and Xamarin.Forms Visual package for FabricUI.

## Changelog
CHANGELOG_CONTENT

## NuGet Package SHA-256 checksums:
```
Xamarin.Forms.Visual.Fabric
FORMS_NUGET_PACKAGE_CHECKSUM

Xamarin.Android.FabricComponents
ANDROID_NUGET_PACKAGE_CHECKSUM

Xamarin.iOS.FabricComponents
IOS_PACKAGE_CHECKSUM
```

EOF

commitMessage=$(git log --format=%B -n 1)
version=$(perl -pe '($_)=/([0-9]+([.][0-9]+)+([-][Rr][Cc][0-9]+)?)/' <<< $commitMessage)
forms_package_checksum=$(sha256sum "../Xamarin.Forms.Visual.Fabric.${version}.nupkg" | awk '{ print $1 }')
android_package_checksum=$(sha256sum "../Xamarin.Android.FabricComponents.${version}.nupkg" | awk '{ print $1 }')
ios_package_checksum=$(sha256sum "../Xamarin.iOS.FabricComponents.${version}.nupkg" | awk '{ print $1 }')
changelog_content=$(sed '1,/### Changes/d;/##/,$d' ../CHANGELOG.MD)
release_description=$(sed "s/FORMS_NUGET_PACKAGE_CHECKSUM/$forms_package_checksum/g" <<< "$release_description")
release_description=$(sed "s/ANDROID_NUGET_PACKAGE_CHECKSUM/$android_package_checksum/g" <<< "$release_description")
release_description=$(sed "s/IOS_PACKAGE_CHECKSUM/$ios_package_checksum/g" <<< "$release_description")

echo "${release_description/CHANGELOG_CONTENT/$changelog_content}" > release_description.txt
