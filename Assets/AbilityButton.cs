using TMPro;
using UnityEngine;

public class AbilityButton : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public void FirstInitialize(Ability ability)
    {
        textBox.text = ability.name;
    }
}