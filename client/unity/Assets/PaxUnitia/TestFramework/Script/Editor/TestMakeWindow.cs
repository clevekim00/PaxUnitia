using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestMakeWindow : EditorWindow
{
	[MenuItem("PaxUnitia/TestMake")]
	public static void ShowWindow()
	{
		TestMakeWindow  window = (TestMakeWindow)EditorWindow.GetWindow(typeof(TestMakeWindow));
	}

	string strSceneNumber;
	string strSceneName;
	string strScriptName;

	void OnGUI()
	{
		strSceneNumber = EditorGUI.TextField(new Rect(10, 10, 300, 17), "Scene Nunmber", strSceneNumber);
		strSceneName = EditorGUI.TextField(new Rect(10, 30, 300, 17), "Scene Name", strSceneName);
		strScriptName = EditorGUI.TextField(new Rect(10, 50, 300, 17), "User Initials", strScriptName);
	}
}
