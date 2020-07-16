using UnityEngine;
using UnityEngine.Serialization;

public class CharacterCanvas : MonoBehaviour
{
    public Battler battler;
    private void Awake()
    {
        foreach (Transform child in transform)
        {
            child.SendMessage("FirstInitialize",battler);
        }
    }

    
}