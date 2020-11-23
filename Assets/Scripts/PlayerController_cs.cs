using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_cs : MonoBehaviour
{
    public CharacterController controller;

    public float turnspeed = 100f;
    public float movespeed = 6f;
    void Update()
    {
       
        transform.Rotate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(0f, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);

    }
}
