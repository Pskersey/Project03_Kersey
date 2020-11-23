using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneExplosionSphere_cs : MonoBehaviour
{
    int j = 0;

    public GameObject light1;
    public GameObject light2;
    // Update is called once per frame
    void Update()
    {
        if (j <= 40) 
        { 
            for (int i = 0; i <= 10; i++)
            {
                gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }

            j += 1;
        } else
        {
            Destroy(gameObject);
            Destroy(light1);
            Destroy(light2);
        }
        
    }
}
