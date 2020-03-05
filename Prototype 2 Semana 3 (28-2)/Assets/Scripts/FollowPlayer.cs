using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    public Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //We can transform the position of the camera and give it a static offset by configuring it using Vector3.
            //transform.position = Player.transform.position + new Vector3(0,1,-5);
        //Better expressed using a public variable.
        transform.position = Player.transform.position + Offset;
    }
}
