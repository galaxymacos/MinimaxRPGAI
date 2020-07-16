using TMPro;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public TextMeshProUGUI textBox;

    public void FirstInitialize(Item item)
    {
        textBox.text = item.name;
    }
}