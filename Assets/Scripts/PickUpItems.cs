using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    // Start is called before the first frame update
    Stack<GameObject> stack;
    Queue<string> itemName;
    Dictionary<int,string> inventory;
    bool popOnce = false;
    int nItems = 0;
    void Start()
    {
       stack = new Stack<GameObject>();
        itemName = new Queue<string>();
        inventory=new Dictionary<int,string>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && stack.Count > 0)
        {
             
            GameObject obj = stack.Pop();
            obj.SetActive(true);
            obj.transform.position = transform.position + transform.TransformVector(Vector3.back) ;
            
            
            popOnce = true;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            popOnce = false;
        }
        if (Input.GetKeyDown(KeyCode.I) && itemName.Count >0)
            {
            Debug.Log("Items recolectados: ");
            foreach (string s in itemName)
            {
                Debug.Log(s);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Item"))
        {
            collision.gameObject.SetActive(false);
            stack.Push(collision.gameObject);
            itemName.Enqueue(collision.gameObject.name);
            inventory.Add(++nItems, collision.gameObject.name);
            Debug.Log(" Has recolectado " + itemName.Count + " items");


        }

        if (collision.gameObject.CompareTag("Cannon"))
        {
            stack.Clear();
            inventory.Clear();
            itemName.Clear();
            Debug.Log("Has cargado la municion");
        }
    }
}
