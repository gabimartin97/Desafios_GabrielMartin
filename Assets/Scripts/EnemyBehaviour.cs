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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyType)
        {
            case EnemyType.Berserker:
                Vector3 distance = transform.position - target.position;
                if (distance.magnitude >= 2f)
                {
                    Vector3 targetPosition = target.position;
                    transform.Translate(speed * Time.deltaTime * Vector3.Normalize(distance));
                    transform.LookAt(targetPosition); //Los modelos estan al reves
                }
                
                break;
            case EnemyType.Sniper:
                Quaternion newRotation = Quaternion.LookRotation(target.transform.position - transform.position);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 10f);
                break;

        }
        
    }
}
