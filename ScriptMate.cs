using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using OpenAI.Models;
using UnityEditor;

public class ScriptMate : EditorWindow
{
    public TextAsset scriptFile;
    private string resultText = "";
    private bool copyResultToClipboard;

    [MenuItem("Window/ScriptMate")]
    public static void ShowWindow()
    {
        GetWindow<ScriptMate>("ScriptMate");
    }

    private Vector2 resultScrollPos = Vector2.zero;

    private void OnGUI()
    {
        GUILayout.Label("Script file:");
        scriptFile = EditorGUILayout.ObjectField(scriptFile, typeof(TextAsset), true) as TextAsset;

        // Add toggle to select whether to copy result to clipboard
        copyResultToClipboard = EditorGUILayout.Toggle("Copy Result to Clipboard", copyResultToClipboard);

        GUILayout.Label("Result:");

        // Enable automatic text wrapping
        EditorStyles.textField.wordWrap = true;

        resultScrollPos = EditorGUILayout.BeginScrollView(resultScrollPos, GUILayout.Height(200));
        resultText = EditorGUILayout.TextArea(resultText, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        EditorGUILayout.EndScrollView();

        if (GUILayout.Button("Summarize Script"))
        {
            resultText = "Generating Summary";
            SummarizeScript();
        }
    }

    private async void SummarizeScript()
    {
        if (scriptFile == null)
        {
            resultText = "No script file selected!";
            return;
        }

        var api = new OpenAIClient();
        var result = await api.CompletionsEndpoint.CreateCompletionAsync("Explain this script in natural language: " + scriptFile.text, temperature: 0.45, maxTokens: 3000, model: Model.Davinci);

        resultText = result.ToString();

        if (copyResultToClipboard)
        {
            EditorGUIUtility.systemCopyBuffer = resultText;
            resultText += "\n\n((This summary has been copied to the system clipboard!))";
        }
    }
}
