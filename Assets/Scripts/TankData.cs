using UnityEngine;

[CreateAssetMenu(menuName = "TankData", order = 1)]
public class TankData : ScriptableObject
{
    public int health;
    public int damage;
    public float speed;
}
