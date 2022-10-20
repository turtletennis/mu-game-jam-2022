using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI ScrapText;
    void Start()
    {
        ScrapText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScrapText(PlayerInventory playerInventory)
    {
        ScrapText.text = playerInventory.NumberOfScrap.ToString();
    }
    
}
