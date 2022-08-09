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
    [SerializeField] Transform Target;
    [SerializeField] float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = Target.position;
        transform.Translate(speed * Time.deltaTime * Vector3.Normalize(targetPosition - transform.position));

    }
}
