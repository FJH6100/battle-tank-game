using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : Singleton<TankService>
{
    public TankView view;
    public Joystick joystick;
    TankModel model;
    TankController controller;
    // Start is called before the first frame update
    void Start()
    {
        model = new TankModel(10f, 100);
        controller = new TankController(model, view);
    }

    // Update is called once per frame
    void Update()
    {
        controller.TankView.MoveTank(joystick.Horizontal, joystick.Vertical, model.Speed);
    }
}
