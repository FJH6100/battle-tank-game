using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    public TankModel(TankData tank)
    {
        Speed = tank.speed;
        Health = tank.health;
        Damage = tank.damage;
    }

    public float Speed { get; }
    public int Health { get; }
    public int Damage { get; }
}
