<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8">
  </head>
  <body>
    <header>
      <h1>ScriptMate</h1>
    </header>
    <nav>
      <ul>
        <li><a href="#about">About</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#usage">Usage</a></li>
        <li><a href="#Special Thanks">Special Thanks</a></li>
      </ul>
    </nav>
    <section id="about">
      <h2>About</h2>
      <p>ScriptMate is a simple and powerful plugin for the Unity Editor which generates a summary of a C# Script into a Natural, Human readable format. This tool utilises OpenAi's processing to generate Script summaries for (near) automatic documentation or a quick understanding of a script without leaving the Editor.</p>
      <img src="https://user-images.githubusercontent.com/38150569/222934358-ce6ab412-f62b-4e8c-a136-2f39145afc68.png" alt="Project image">
    </section>
    <section id="installation">
      <h2>Installation</h2>
      <p>
• Open your Unity project settings
- Navigate to the Package Manager in Project Settings | Edit -> Project Settings -> Package Manager
- Add the OpenUPM package registry inside Scoped Registries (be sure to check Enable Preview Packages and Show Dependencies):

```
Name: ScriptMate
URL: https://package.openupm.com
Scope(s):
com.openai
com.utilities
```

- Open the Unity Package Manager Window | Window -> Package Manager
- Click the "Packages: " drop-down at the top, and switch it to "My Registries"
- OpenAI should be in the list, click it and click "Install/Update"
- Add `ScriptMate.cs` to any folder called `"Editor"` in your project 
- Define your own API key in the scriptable object that comes included or create your own (see usage)
        
You must provide your own API key from openAI. It can be placed in the OpenAIConfigurationSettings included or you can make your own. You can create a new one by using the context menu of the project pane and creating a new OpenAI > OpenAIConfigurationSettings scriptable object.<br>
Save the key directly into a scriptable object and place it in any resources folder.<br></p>
    </section>
    <section id="usage">
      <h2>Usage</h2>
      <p>• In the Unity Editor, Select Window -> ScriptMate<br>
      • Drag any script object into the 'Script File' field<br>
      • Press Summarize Script<br><br>
</p>
    </section>
    <section id="Special Thanks">
      <h2>Special Thanks</h2>
Kaeden Irvine<br>
<p>Stephen Hodgson https://github.com/RageAgainstThePixel/com.openai.unity <a href="https://openupm.com/packages/com.openai.unity/"><img src="https://img.shields.io/npm/v/com.openai.unity?label=openupm&amp;registry_uri=https://package.openupm.com" /></a><br>
OpenAI https://openai.com/<br></p>
    </section>
  </body>
</html>
