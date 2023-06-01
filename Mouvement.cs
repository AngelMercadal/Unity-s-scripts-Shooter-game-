using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float ejeX = Input.GetAxis("Horizontal");

        float ejeZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * ejeX + transform.forward * ejeZ;


        controller.Move(move * speed * Time.deltaTime);

        controller.Move(move.normalized * speed * Time.deltaTime);







    }

    public CharacterController controller;

    public float speed = 8.0f;

}
