# ScriptMate
ScriptMate is a Unity3D editor plugin that generates a summary of a script file using OpenAI's natural language processing. It allows the user to select a script file and then generate a summary of it with ease.

![image](https://user-images.githubusercontent.com/38150569/222929912-e6907a5f-b800-4e8d-87a9-2773bc58cba0.png)

## Requirements
- Unity 2021.3 LTS or higher<br>
- <a href="https://openupm.com/packages/com.openai.unity/">OpenAI UPM Package</a>

## Installation
- Open your Unity project settings
- Navigate to `Package Manager`
- Add the OpenUPM package registry:

```Name: OpenUPM
URL: https://package.openupm.com
Scope(s):
com.openai
com.utilities
```

- Open the `Unity Package Manager window`
- Change the Registry from Unity to My Registries
- Add the OpenAI package
- Update the package
- Add `ScriptMate.cs` to any folder called `"Editor"` in your project
- Define your own API key in the scriptable object (see <a href="https://github.com/Kalfadda/ScriptMate/edit/main/README.md#usage">Usage</a>)

## Usage
You must provide your own API key from openAI. It can be placed in the OpenAIConfigurationSettings but you must create the scriptableobject first:<br>
- You can save the key directly into a scriptable object that is located in the `Assets/Resources` folder.
- Create a new one by using the context menu of the project pane and creating a new `OpenAI > OpenAIConfigurationSettings` scriptable object.


### Special Thanks
Stephen Hodgson for creating the UPM package: https://github.com/RageAgainstThePixel/com.openai.unity <a href="https://openupm.com/packages/com.openai.unity/"><img src="https://img.shields.io/npm/v/com.openai.unity?label=openupm&amp;registry_uri=https://package.openupm.com" /></a><br>
OpenAI: https://openai.com/
