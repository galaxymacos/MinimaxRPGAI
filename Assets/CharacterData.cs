using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public int hp;
    public int atk;
    public int mov;
    public List<Item> items;
    public List<Ability> abilities;
}