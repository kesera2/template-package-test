using UnityEditor;
using UnityEngine;

public class HelloWorldEditor : EditorWindow
{
    [MenuItem("Window/Hello World Editor")]
    public static void ShowWindow()
    {
        GetWindow<HelloWorldEditor>("Hello World");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Click Me"))
        {
            Debug.Log("Hello, World!");
        }
    }
}