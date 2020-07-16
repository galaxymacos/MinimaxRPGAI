using UnityEngine;

public class ItemPanel : MonoBehaviour
{
    private Battler mc;
    public GameObject itemButtonPrefab;
    
    /// <summary>
    /// This method should be called by its parent to initialize
    /// </summary>
    /// <param name="battler"></param>
    public void FirstInitialize(Battler battler)
    {
        mc = battler;
        ShowItemInfoOnButton();
    }

    public void ShowItemInfoOnButton()
    {
        var items = mc.resource.items;
        foreach (var item in items)
        {
            var itemButton = Instantiate(itemButtonPrefab, transform);
            var itemButtonScript = itemButton.GetComponent<ItemButton>();
            if (itemButtonScript == null)
            {
                Debug.LogError("No ItemButton script on gameObject");
            }
            itemButtonScript.FirstInitialize(item);

        }
    }

}