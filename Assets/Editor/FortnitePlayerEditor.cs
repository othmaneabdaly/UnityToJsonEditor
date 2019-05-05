﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;


public class PlayerModelEditor : EditorWindow
{
    PlayerModel p = new PlayerModel();
    [MenuItem("Window/Editor")]
    static void Init()
    {
        GetWindow<PlayerModelEditor>("Welcome");
        PlayerModelEditor window = (PlayerModelEditor)EditorWindow.GetWindow(typeof(PlayerModelEditor));
        window.maximized = true;
        window.name = "Welcome";
        window.Show();
    }
    void OnEnable()
    {
        List<PlayerModel> listPlayer;
    }
    void OnGUI()
    {
        List<PlayerModel> listPlayer;

        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        //ScriptableObject target = this;
        //SerializedObject so = new SerializedObject(target);
        //SerializedProperty stringsProperty = so.FindProperty("listPlayer");

        //EditorGUILayout.PropertyField(stringsProperty, true); // True means show children
        //so.ApplyModifiedProperties();
        p.Name = EditorGUILayout.TextField("Name: ", p.Name);
        p.Health = EditorGUILayout.IntField("Health: ", p.Health);
        p.Armor = EditorGUILayout.IntField("Armor: ", p.Armor);
        if (GUILayout.Button("Save"))
        {
            
        }
         


    }
}
