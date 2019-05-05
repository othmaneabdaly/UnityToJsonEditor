using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyGamePlayer
{
    public string Name;
    public int Health;
    public int Armor;

    public override string ToString()
    {
        return "Name: "+Name+",Health: "+Health+",Armor: "+Armor;
    }
}
public class Players
{
    public Dictionary<string, AnyGamePlayer> PlayersList;
}
