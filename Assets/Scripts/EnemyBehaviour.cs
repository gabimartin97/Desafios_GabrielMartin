using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
   
    enum EnemyType
    {
        Berserker,
        Sniper
    }

    [SerializeField] EnemyType enemyType;
    [SerializeField] Transform target;
    [SerializeField] float speed = 5f;
    [SerializeField] private float chaseDistance = 20f;
    
    private bool chasePlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        ChaseRaycast();
    }
    // Update is called once per frame
    void Update()
    {
        if (chasePlayer)
        {
            switch (enemyType)
            {
                case EnemyType.Berserker:
                    Vector3 distance = transform.position - target.position;
                    if (distance.magnitude >= 2f)
                    {
                        Vector3 targetPosition = target.position;
                        transform.LookAt(targetPosition);
                        transform.Translate(speed * Time.deltaTime * Vector3.forward);

                    }

                    break;
                case EnemyType.Sniper:
                    Quaternion newRotation = Quaternion.LookRotation(target.transform.position - transform.position);
                    transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 10f);
                    break;

            }
        }
        
    }
    void ChaseRaycast()
    {
        RaycastHit hit;
        Vector3 direction =   (target.position - transform.position);
        Debug.DrawRay(transform.position, direction.normalized * chaseDistance);
        if (Physics.Raycast(transform.position, direction, out hit, chaseDistance))
        {

            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("COLLISION CON PLAYER");
                
                chasePlayer = true;
                
            }
        }

    }
}
