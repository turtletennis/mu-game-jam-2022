using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfScrap { get; private set; }

    public UnityEvent<PlayerInventory> OnScrapCollected;
    public void ScrapCollected()
    {
        NumberOfScrap++;
        OnScrapCollected.Invoke(this);
    }
}
    
