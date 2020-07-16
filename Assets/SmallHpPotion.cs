using UnityEngine;

public class SmallHpPotion : Item
{
    private int amount = 10;

    public override void Play(Battler battler)
    {
        battler.currentHp = Mathf.Clamp(battler.currentHp+amount, 0, battler.resource.hp); 
    }
}