using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControllerTight : MonoBehaviour
{
    [SerializeField] GameObject particlePrefab;

    public void SpawnParticleOnBox (ClickableBoxTight box)
    {
        var particle = Instantiate(particlePrefab, box.transform.position, Quaternion.identity);
        Destroy(particle, 3f);
    }
}
