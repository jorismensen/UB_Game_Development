using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Speed variable
    public float Speed = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        //Decimals can only be used with a "float" (float = decimal number)

        //transform.Translate(0,0,0.1f);
            //better written as
        //transform.Translate(Vector3.forward * 0.05f);
            //Now we have a static speed, it will vary depending on hardware.
            //With the goal of 60 fps. deltaTime means 1/60 (60 frames per second "0.16")
            //We use this to balance the game so it doesn't depend on the hardware, everyone will have the same speed.
        //transform.Translate(Vector3.forward * Time.deltaTime * 20f);
            //Better edited using a variable
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
