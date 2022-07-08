using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_UI : MonoBehaviour
{
    public Text score;
    public Text playerName;
    public GameObject gameOver;

    void Start()
    {
        gameOver.SetActive(false);
        playerName.text = GameMaster.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = $"Score: {GameMaster.Instance.score}";
        if (GameMaster.Instance.gameOverr)
        {
            gameOver.SetActive(true);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        GameMaster.Instance.gameOverr = false;
        GameMaster.Instance.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
