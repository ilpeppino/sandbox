using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] int currentHealthPoints = 100;

    public void TakeDamage(int damage)
    {
        currentHealthPoints -= damage;
    }

}
