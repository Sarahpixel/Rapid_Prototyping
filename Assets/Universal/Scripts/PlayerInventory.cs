using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfWrenches { get; private set; }

    public UnityEvent<PlayerInventory> OnWrenchCollected;
    public void WrenchCollected()
    {
        NumberOfWrenches++;
        OnWrenchCollected.Invoke(this);
        Debug.Log("Collected Pickup");
    }
}
