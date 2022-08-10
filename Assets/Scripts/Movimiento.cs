using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]  float speed = 5;
    [SerializeField] float rotationSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = Vector3.zero;
        Vector3 rotacion = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direccion += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direccion += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direccion += Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion += Vector3.back;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotacion += Vector3.down;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotacion += Vector3.up;
        }


        transform.Translate(direccion.normalized * Time.deltaTime * speed *(-1f));
        transform.Rotate(rotacion * Time.deltaTime * rotationSpeed);

              
        
    }
}
