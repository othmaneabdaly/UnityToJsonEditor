using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyGamePlayer : MonoBehaviour
{
    public string Name;
    public int Health;
    public int Armor;
}
public class Players
{
    public Dictionary<string, AnyGamePlayer> PlayersList;
}
