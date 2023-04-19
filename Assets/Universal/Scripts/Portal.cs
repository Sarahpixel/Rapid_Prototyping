using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    //public GameObject myPartner;
    //public bool canTeleport = true;

    //// Start is called before the first frame update
    //private void Start()
    //{
    //    canTeleport = true;
    //}

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player") && canTeleport)
    //    {
    //        myPartner.GetComponent<Portal>().canTeleport = false;
    //        //Offset the Y position so we dont phasde through the ground
    //        Vector3 endPos = new Vector3(myPartner.transform.position.x, 1, myPartner.transform.position.z);
    //        other.transform.position = endPos;
    //    }
    //}

    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player") && !canTeleport)
    //        canTeleport = true;
    //}
    public Transform player;
    public Transform reciever;

    private bool playerIsOverlaping = false;

    void Update()
    {
        if (playerIsOverlaping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            if (dotProduct < 0f)
            {
                //Teleport player
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 0;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;

                playerIsOverlaping = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlaping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlaping = false;
        }
    }
}
