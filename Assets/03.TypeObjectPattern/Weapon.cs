using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] WeaponData weaponData;

    public void Attack (Target target)
    {
        target.TakeDamage(weaponData.damage);
    }

}
