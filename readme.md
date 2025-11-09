# Gorilla Tag Mod Template

.NET Project Template for PCVR Gorilla Tag Mods
Original By Graic, I forked and updated and added some stuff

## Usage

To install the template, Locate to (FileDirectory)/src/Content/GorillaTagModTemplateProject, Type in File Directory: "cmd", run
`dotnet new install .` from the command line.

To enable the template to be used in Visual Studio, open Visual Studio without code and navigate to `Tools/Options/Environment/Preview Features`.
Make sure that "Show all .NET Core Templates in the New Project Dialog" is checked.
The template should then appear in Visual Studio Templates, under "Gorilla Tag Mod".

## Parameters

- **Project Name** is used as the name of the mod. Do not put spaces in the project name, as it will prevent the mod from loading.
- **Author Name** is the name of the author, used for the plugin info.
- **Gorilla Tag Location** is the path to the place where Gorilla Tag is installed. By default, it is `C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag`. This is used for copying the mod on build and for referencing game files.

## Template Information

The template creates the following files of note:
* [Main/Entry.cs](src/Content/GorillaTagModTemplateProject/Main/Entry.cs): The main class of your mod. Most of your code should go here.
* [Main/Vars.cs](src/Content/GorillaTagModTemplateProject/Main/Vars.cs): Static Variables in your code. You can assign and set, Make sure they are Public Static variables.
* [Helpful/GTLogger.cs](src/Content/GorillaTagModTemplateProject/Helpful/GTLogger.cs): This will be your Logger, 
* [Patches/ExamplePatch.cs](src/Content/GorillaTagModTemplateProject/Patches/ExamplePatch.cs): This demonstrates how patches are created, you should remove or modify it as you see fit.
* [Helpful/Tools.cs](src/Content/GorillaTagModTemplateProject/Helpful/Tools.cs): This is where you can Create tools, This is mainly for making stuff less clumped together.
* [Components/Callbacks.cs](src/Content/GorillaTagModTemplateProject/Components/Callbacks.cs): This is MonoBehaviourPunCallbacks, This can be used to run a method when joining a room and loads more: [DOCS](https://doc-api.photonengine.com/en/pun/current/class_photon_1_1_pun_1_1_mono_behaviour_pun_callbacks.html)
* [MakeRelease.ps1](src/Content/GorillaTagModTemplateProject/MakeRelease.ps1): This script generates a [MonkeModManager](https://github.com/DeadlyKitten/MonkeModManager/) compatible release (named ModName-v.zip). You should use this to create builds that you share with others.
* [Directory.Build.props](src\Content\GorillaTagModTemplateProject\Directory.Build.props): This file contains information about where dependencies are located. If you are getting CS024 (type could not be found) errors, GamePath is probably wrong. 


