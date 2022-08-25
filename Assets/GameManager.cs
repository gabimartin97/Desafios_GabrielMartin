using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    private static int score=0;
    private static float gameTime = 0;


    public static GameManager instance;

    public static int Score { get => score; set => score = value; }
    public static float GameTime { get => gameTime; set => gameTime = value; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        GameTime = Time.time;
    }
}