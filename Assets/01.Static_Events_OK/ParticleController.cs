using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] GameObject particlePrefab;

    private void Awake()
    {
        // ParticleController is listening on OnAnyBoxClicked event from ClickableBox. When it detects the event, it calls the SpawnParticleOnBox
        ClickableBox.OnAnyBoxClicked += SpawnParticleOnBox;
    }

    // OnAnyBoxClicked is declared in the ClickableBox with a box parameter. Therefore the method invoked needs to have a ClickableBox as well in the parameters
    public void SpawnParticleOnBox(ClickableBox box)
    {
        var particle = Instantiate(particlePrefab, box.transform.position, Quaternion.identity);
        Destroy(particle, 3f);
    }
}
