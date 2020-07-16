using System;
using UnityEngine;

public class TurnManager: MonoBehaviour
{
    public Battler battlerA;
    public Battler battlerB;

    private void Awake()
    {
        battlerA.opponent = battlerB;
        battlerB.opponent = battlerA;
    }

    private void Update()
    {
        if (battlerA.currentMov <= 0 || battlerB.currentMov <= 0)
            return;

        if (battlerA.currentMov > 0)
        {
            battlerA.currentMov -= Time.deltaTime;
            if (battlerA.currentMov <= 0)
            {
                battlerA.currentMov = 0;
                battlerA.Act();
            }
        }

        if (battlerB.currentMov > 0)
        {
            battlerB.currentMov -= Time.deltaTime;
            if (battlerB.currentMov <= 0)
            {
                battlerB.currentMov = 0;
                battlerB.Act();
            }
        }

        
    }
}