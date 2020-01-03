using UnityEngine;

[CreateAssetMenu(menuName ="Weapon Data")]

public class WeaponData : ScriptableObject
{
    public int damage;
    public string message;
    public int stunDuration;
    public int freezeDuration;

}
