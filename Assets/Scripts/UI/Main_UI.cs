using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_UI : MonoBehaviour
{
    public Text score;
    public Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = GameMaster.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = $"Score: {GameMaster.Instance.score}";
    }
}
