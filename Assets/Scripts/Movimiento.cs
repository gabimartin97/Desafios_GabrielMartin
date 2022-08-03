using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]  public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
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
                

        transform.Translate(direccion.normalized * Time.deltaTime * speed);
    }
}
