using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public PlayerData data;
    [SerializeField] GameObject itemUI_Prefab;
    [SerializeField] GameObject itemsContent;
    [SerializeField] GameObject itemData;
    [SerializeField] TMP_Text itemNameField;
    [SerializeField] TMP_Text itemDescriptionField;
    [SerializeField] List<Sprite> itemsIcons;


    ItemsManager items;

    private void Start()
    {
        items = ItemsManager.Instance;
    }

    public void UpdateItemsWindow()
    {
        foreach(Transform child in itemsContent.transform)
        {
            Destroy(child.gameObject);
        }
        itemData.SetActive(false);
        GameObject temp;
        for(int i = 0; i < items.items.Count; i++)
        {
            if (items.items[i].isOwned == true)
            {
                temp = Instantiate(itemUI_Prefab);
                temp.transform.SetParent(itemsContent.transform);
                temp.GetComponent<UI_Data>().intValue = items.items[i].id;
                temp.GetComponent<UI_Data>().image.sprite = itemsIcons[items.items[i].iconID];
            }
        }

    }
    public void ClickedOnItem(int id)
    {
        itemData.SetActive(true);
        Item item = ItemsManager.Instance.items[id];
        itemNameField.text = item.itemName;
        itemDescriptionField.text = item.description;
    }

}
