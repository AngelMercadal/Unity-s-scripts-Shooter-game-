using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetive : MonoBehaviour
{

    public void  DamageObj (int dmg)
    {
        HPEnemy -= dmg;

        if (HPEnemy==0)

        {
            Destroy(gameObject);
        }


    }






    public int HPEnemy = 3;
}
