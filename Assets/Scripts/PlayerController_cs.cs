using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_cs : MonoBehaviour
{
    public CharacterController controller;

    public ManaBar_cs manaBar;

    public AudioSource _OOMSFX = null;

    public Object _objectToInstantiate;
    

    public float turnspeed = 100f;
    public float movespeed = 6f;

    public float maxMana = 100;
    public float currentMana;
    public float manaRegen = 6;

    bool allowfire;
    bool canShoot = true;

    

    private void Start()
    {
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    void Update()
    {
       
        transform.Rotate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(0f, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && currentMana >= 20 && canShoot)
        {
            CastArcaneExplosion();
            StartCoroutine(FireRate());
            //Instantiate(prefab, )
            //GameObject bulletObject = Instantiate(bulletPrefab);
            Instantiate(_objectToInstantiate, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentMana <20)
        {
            Debug.Log("Not Enough Mana!");
            _OOMSFX.Play();
        }

        currentMana += manaRegen * Time.deltaTime;
        manaBar.SetMana(currentMana);

        if (currentMana < 0) currentMana = 0;

        if (currentMana > maxMana) currentMana = maxMana;

    }

    public void CastArcaneExplosion()
    {
        allowfire = false;
        currentMana -= 20;
        manaBar.SetMana(currentMana);
        Debug.Log("Casted Arcane Explosion!");
     

    }

    private IEnumerator FireRate()
    {
        canShoot = false;
        yield return new WaitForSeconds(1f);
        canShoot = true;

    }
}
