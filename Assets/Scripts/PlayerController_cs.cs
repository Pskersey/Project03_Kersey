using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_cs : MonoBehaviour
{
    public CharacterController controller;

    public ManaBar_cs manaBar;

    public float turnspeed = 100f;
    public float movespeed = 6f;

    public int maxMana = 100;
    public int currentMana;
    public float manaRegen = 3;

    private void Start()
    {
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    void Update()
    {
       
        transform.Rotate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(0f, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && currentMana >= 20)
        {
            CastArcaneExplosion();
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentMana <20)
        {
            Debug.Log("Not Enough Mana!");
        }


        
    }

    public void CastArcaneExplosion()
    {
        currentMana -= 20;
        manaBar.SetMana(currentMana);
        Debug.Log("Casted Arcane Explosion!");

    }
}
