using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        rotacion = rotacion - mouseY;
        rotacion = Mathf.Clamp(rotacion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacion, 0f, 0f);

        jugador1.Rotate(Vector3.up * mouseX);







    }


    public float Sensitivity = 150f;

    public Transform jugador1;

    public float rotacion = 0f;






}
