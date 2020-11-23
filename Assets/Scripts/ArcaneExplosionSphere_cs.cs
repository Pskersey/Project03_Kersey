using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneExplosionSphere_cs : MonoBehaviour
{
    int j = 0;

    // Update is called once per frame
    void Update()
    {
        if (j <= 10) 
        { 
            for (int i = 0; i <= 10; i++)
            {
                gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }

            j += 1;
        }
        
    }
}
