using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Player Variable
    public float movementSpeed;
    Rigidbody rb;

    public TextMeshProUGUI scoreText;
    
    //public Score _score;
    public int score = 0;

   
    private void Start()
    {

       
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation= true;


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            score += 1;
            Destroy(other.gameObject);
        }

    }
   
       

    private void Update()
    {
       
        SpeedControl();
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
    }
    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limits the velocity if needed
        if(flatVel.magnitude > movementSpeed)
        {
            Vector3 limitVel = flatVel.normalized * movementSpeed;
            rb.velocity = new Vector3(limitVel.x, rb.velocity.y, limitVel.z);
        }
    }
   
}
