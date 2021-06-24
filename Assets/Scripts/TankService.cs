using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : Singleton<TankService>
{
    public TankView view;
    public Joystick joystick;
    public TankData myTank;
    public GameObject Bullet;
    TankModel model;
    TankController controller;
    // Start is called before the first frame update
    void Start()
    {
        model = new TankModel(myTank);
        controller = new TankController(model, view);
    }

    // Update is called once per frame
    void Update()
    {
        controller.TankView.MoveTank(joystick.Horizontal, joystick.Vertical, model.Speed);
        if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(1);

            if (touch.phase == TouchPhase.Began)
            {
                controller.TankView.Shoot(Bullet);
            }
        }
        if (Input.GetMouseButtonDown(0))
            controller.TankView.Shoot(Bullet);
    }
}
