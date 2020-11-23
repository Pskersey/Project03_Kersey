using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneExplosion_cs : MonoBehaviour
{
    public ParticleSystem _particleSystemToPlay = null;
    public AudioClip _audioClipToPlay = null;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Arcane Explosion Hit Something!");
        var EnemyComponent = collision.gameObject.GetComponent<EnemyController_cs>();
        if (EnemyComponent == null)
        {
            collision.gameObject.GetComponent<EnemyController_cs>().TakeDamage(1);
            Debug.Log("Arcane Explosion Hit An Enemy!");
        }
    }

    void Update()
    {
        
    }
}
