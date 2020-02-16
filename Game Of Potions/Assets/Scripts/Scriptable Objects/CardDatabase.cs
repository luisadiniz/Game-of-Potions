using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDatabase", menuName = "Scriptable/CardDatabase")]
public class CardDatabase : ScriptableObject
{
    public List<CardInfo> cardDatabase = new List<CardInfo>();
}

