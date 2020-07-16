using UnityEngine;

public class AbilityPanel : MonoBehaviour
{
    private Battler mc;
    public GameObject abilityButtonPrefab;
    
    /// <summary>
    /// This method should be called by its parent to initialize
    /// </summary>
    /// <param name="battler"></param>
    public void FirstInitialize(Battler battler)
    {
        mc = battler;
        SendAbilityInfoToButton();
    }

    public void SendAbilityInfoToButton()
    {
        var abilities = mc.resource.abilities;
        foreach (Ability ability in abilities)
        {
            var abilityButton = Instantiate(abilityButtonPrefab, transform);
            var abilityButtonScript = abilityButton.GetComponent<AbilityButton>();
            if (abilityButtonScript == null)
            {
                Debug.LogError("Can't find AbilityButton script on ability button");
            }
            abilityButtonScript.FirstInitialize(ability);
        }
    }
}