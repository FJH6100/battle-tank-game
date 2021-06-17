using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : Singleton<TankController>
{
    public Joystick joystick;
    float speed = 40f;
    float horiMove = 0f;
    float vertiMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(joystick.Horizontal * .01f, 0, joystick.Vertical * .01f);
    }
}
