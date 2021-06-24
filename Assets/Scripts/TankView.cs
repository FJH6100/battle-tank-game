using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Tank view created");
    }

    public void MoveTank(float horizontal, float vertical, float speed)
    {
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

    public void Shoot(GameObject Bullet)
    {
        Debug.Log("Shoot");
        Instantiate(Bullet, transform.position + new Vector3(0,1.5f,3), Quaternion.identity);
    }
}
