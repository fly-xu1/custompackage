using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomPackageTest))]
public class CustomPackageEditor : Editor
{
    public CustomPackageTest customPackageTest;
    private void OnEnable()
    {
        customPackageTest = (CustomPackageTest)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Spawn"))
        {
            customPackageTest.Spawn();
        }
    }
}

