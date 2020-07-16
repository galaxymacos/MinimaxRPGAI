using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    private Battler _battler;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void FirstInitialize(Battler battler)
    {
        _battler = battler;
        
    }

    private void Update()
    {
        image.fillAmount = _battler.currentHp / (float)_battler.resource.hp;
    }
}
