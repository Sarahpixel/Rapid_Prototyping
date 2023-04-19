using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    //[SerializeField] private Image key;
    public int NumberOfWrenches { get; private set; }

    public UnityEvent<PlayerInventory> OnWrenchCollected;
    public void WrenchCollected()
    {
        NumberOfWrenches++;
        OnWrenchCollected.Invoke(this);
        Debug.Log("Collected Pickup");
    }
}
