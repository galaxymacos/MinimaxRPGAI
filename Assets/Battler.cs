using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Battler: MonoBehaviour
{
    public CharacterData resource;

    [HideInInspector] public Battler opponent;
    
    public float currentMov;
    public int currentHp;

    public bool Acting => acting;
    private bool acting;

    private void Awake()
    {
        currentMov = resource.mov;
        currentHp = resource.hp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
    }

    public void Act()
    {
        acting = true;
    }
}