using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_UI : MonoBehaviour
{
    public InputField inputField;

    void Start()
    {
        if (GameMaster.Instance != null && GameMaster.Instance.playerName != "")
        {
            inputField.text = GameMaster.Instance.playerName;
        }
    }

    public void NameChanged()
    {
        GameMaster.Instance.playerName = inputField.text;
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
