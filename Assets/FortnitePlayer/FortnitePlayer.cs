using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public string Name;
    public int Health;
    public int Armor;
}
public class Players
{
    public Dictionary<string, PlayerModel> PlayersList;
    public PlayerModel GetPlayerByName(string name)
    {
        foreach(KeyValuePair < string, PlayerModel> player in PlayersList)
        {
            if(player.Key.Equals(name))
            {
                return player.Value;
            }
        }
        return null;
    }
}
