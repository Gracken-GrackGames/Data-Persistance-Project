using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public TextMeshProUGUI highestScore;
    public TextMeshProUGUI showPlayer;
    public Text inputText;


    // Start is called before the first frame update
    void Start()
    {
        string highScorePlayer = MenuManager.Instance.bestPlayerName;
        int highScoreCount = MenuManager.Instance.highScore;
        highestScore.text = "Highest Score: " + highScorePlayer + " | " + highScoreCount;

       
    }

    // Update is called once per frame
    void Update()
    {
        showPlayer.text = "Player: " + inputText.text;
    }

    public void StartGame()
    {
        MenuManager.Instance.playerName = inputText.text;
        SceneManager.LoadScene(1);
    }

    public void ShowScores()
    {

    }

    public void EndGame()
    {
        MenuManager.Instance.SaveGameInfo(MenuManager.Instance.highScore);
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
