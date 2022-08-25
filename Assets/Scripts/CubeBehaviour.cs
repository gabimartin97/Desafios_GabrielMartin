using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        castRay();
    }

    void castRay()
    {
        RaycastHit hit;
        Vector3 direction = (target.position - transform.position);
        Debug.DrawRay(transform.position, direction.normalized * 20);
        if (Physics.Raycast(transform.position, direction, out hit, 20))
        {

            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("COLLISION CON PLAYER");

               GetComponentInChildren<Light>().enabled = false;

            }
        }
    }
}
