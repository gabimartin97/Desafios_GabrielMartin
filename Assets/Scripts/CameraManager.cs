using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] cameras;
    int camerasCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        cameras[0].SetActive(true);
        cameras[1].SetActive(false);
        cameras[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            camerasCount++;
            if(camerasCount >= cameras.Length)
            {
                camerasCount = 0;
            }

            for(int i =0; i < cameras.Length;i++)
            {
                if(i == camerasCount)
                {
                    cameras[i].SetActive(true);
                    continue;
                } 
                cameras[i].SetActive(false);
                
            }
        }
    }
}
