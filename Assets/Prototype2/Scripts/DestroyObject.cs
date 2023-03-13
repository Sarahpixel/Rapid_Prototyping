using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public Player playerScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            Destroy(other.gameObject);
            playerScript.score -= 2;
        }
            
    }
}
