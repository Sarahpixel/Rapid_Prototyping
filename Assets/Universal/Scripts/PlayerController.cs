using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //References to the player
    private GameObject focalPoint;
    private Rigidbody playerRb;
    public float speed = 5.0f;

    //reference to pickup
    public bool hasPowerUp = false;
    private float powerUpStremgth = 15.0f;
    public GameObject powerupIndicator;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp= true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp= false;
        powerupIndicator.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromplayer = (collision.gameObject.transform.position - transform.position);
             
            enemyRigidbody.AddForce(awayFromplayer * powerUpStremgth, ForceMode.Impulse);
            Debug.Log("Has Collided With: " + collision.gameObject.name + " With powerup set to " + hasPowerUp);
        }
    }
}
