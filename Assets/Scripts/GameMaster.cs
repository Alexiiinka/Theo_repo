using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster Instance;
    public string playerName = "";
    public int score = 0;
    public bool gameOverr = false;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverr = true;
    }

}
