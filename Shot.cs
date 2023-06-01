using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(miCamara.transform.position, miCamara.transform.forward, out hit, range))
            { Debug.Log("Le has dado a algo");

                Objetive objetive = hit.transform.GetComponent<Objetive>();
                if (objetive!=null)
                objetive.DamageObj(dmg);
            
         }

            else
            {

                Debug.Log("No le has dado a nada");

            }



        }
    }

    public float range=150f;

    public Camera miCamara;

    public int dmg=1;


}
