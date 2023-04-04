using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{

    protected Joystick Joystick;
    protected joybuttonscript joybuttonscript;
    // Use this for initialization
    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
        joybuttonscript = FindObjectOfType<joybuttonscript>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(Joystick.Horizontal * 10f,
                                            rigidbody.velocity.y,
                                            Joystick.Vertical * 10f);


    }
}
