using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class AnyGamePlayerEditor
{
    public override void OnInspectorGUI()
    {
        AnyGamePlayer player = (AnyGamePlayer)target;
        EditorGUILayout.TextField("Name:", player.Name);
        EditorGUILayout.IntField("Health:", player.Health);
        EditorGUILayout.IntField("Armor:", player.Armor);
    }
}
