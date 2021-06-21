using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    //public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tank view created");
    }

    public void MoveTank(float horizontal, float vertical, float speed)
    {
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }
}
