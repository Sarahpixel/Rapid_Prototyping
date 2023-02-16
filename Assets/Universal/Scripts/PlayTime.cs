using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTime : GameBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        ExecuteAfterSeconds(2, () => ScaleToZero(player)); //Advance programing lambda expression

        ExecuteAfterSeconds(2, () =>
        {
            ChangePlayerColor();
            print("Yay");
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangePlayerColor();
        }
    }
    void ChangePlayerColor()
    {
        player.GetComponent<Renderer>().material.color = GetRandomColor();
    }
}
