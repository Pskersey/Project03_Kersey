using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneExplosion_cs : MonoBehaviour
{
    public ParticleSystem _particleSystemToPlay = null;
    public ParticleSystem _particleSystemToPlay2 = null;
    public ParticleSystem _particleSystemToPlay3 = null;
    public AudioSource _audioClipToPlay = null;
    public AudioSource _audioClipToPlay2 = null;

    float lifeTime = 1.5f;

    private void Start()
    {
        _audioClipToPlay.Play();
        _audioClipToPlay2.Play();
        _particleSystemToPlay.Play();
        _particleSystemToPlay2.Play();
        _particleSystemToPlay3.Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Arcane Explosion Hit Something!");

        var EnemyComponent = collision.gameObject.GetComponent<EnemyController_cs>();
        if (EnemyComponent != null)
        {
            collision.gameObject.GetComponent<EnemyController_cs>().TakeDamage(1);
            Debug.Log("Arcane Explosion Hit An Enemy!");
        }
    }

    void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
