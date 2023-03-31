using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public int level;
    public int health;
    public int[] inventory;
    private const int KEY = 1234;

    public string ToEncryptedJson() 
    {
        string json = JsonUtility.ToJson(this);
        char[] charArray = json.ToCharArray();

        for (int i = 0; i < charArray.Length; i++) 
        {
            charArray[i] = (char)(charArray[i] ^ KEY); //apply XOR encryption
        }
        return new string(charArray);
    }

    public static GameData FromEncryptedJson(string json) 
    {
        char[] charArray = json.ToCharArray();

        for (int i = 0; i < charArray.Length; i++) 
        {
            charArray[i] = (char)(charArray[i] ^ KEY); //undo XOR encryption
        }

        json = new string(charArray);
        return JsonUtility.FromJson<GameData>(json);
    }
}
