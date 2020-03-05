using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Speed variable
    public float Speed = 20.0f;
    //Turning speed variable
    public float TurnSpeed;

    // Start is called before the first frame update
    void Start () {
        Debug.Log ("START");
    }

    // Update is called once per frame
    void Update () {

        float horizontalInput = Input.GetAxis ("Horizontal");
        float verticalInput = Input.GetAxis ("Vertical");
        //We draw update to log each frame.
        //Debug.Log("UPDATE");
        //we can use this to log the axis transition using our Input.
        //Debug.Log(horizontalInput);

        //Move the vehicle forward
        //Decimals can only be used with a "float" (float = decimal number)
        //transform.Translate(0,0,0.1f);
        //better written as
        //transform.Translate(Vector3.forward * 0.05f);
        //Now we have a static speed, it will vary depending on hardware.
        //With the goal of 60 fps. deltaTime means 1/60 (60 frames per second "0.16")
        //We use this to balance the game so it doesn't depend on the hardware, everyone will have the same speed.
        // deltaTime is completion time since last frame, used to always have the same speed no matter the hardware.
        //transform.Translate(Vector3.forward * Time.deltaTime * 20f);
        //Better edited using a variable, in this case "speed"
        transform.Translate (Vector3.forward * Time.deltaTime * Speed * verticalInput);

        //transform.Translate(Vector3.right * Time.deltaTime * TurnSpeed);
        //transform.Translate (Vector3.right * Time.deltaTime * TurnSpeed * horizontalInput);
        transform.Rotate (Vector3.up * Time.deltaTime * TurnSpeed * horizontalInput);
    }
}