using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldControl : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI Scoreboard;
    public TextMeshProUGUI Highscore;
    public TextMeshProUGUI Highscorer;
    public GameObject GameOverUI;
    public GameObject HighscoreUI;
    public TMP_InputField Inputfield;
    public HighscoreControl HighscoreControl;



    // Start is called before the first frame update
    void Awake()
    {
        GameOverUI.SetActive(false);
        HighscoreUI.SetActive(false);
        Highscore.text = PlayerPrefs.GetInt("highscore").ToString();
        Highscorer.text = "Von: " + PlayerPrefs.GetString("highscorer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint(int amount)
    {
        score += amount;
        Scoreboard.text = score.ToString();
        if(PlayerPrefs.GetInt("highscore") < score)
        {
            Highscore.text = score.ToString();
        }
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0;

        bool isHighscore = HighscoreControl.HighscoreCheck(score);
        HighscoreUI.SetActive(isHighscore);


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void SubmitHighscore()
    {
        string name = Inputfield.text;
        if(!string.IsNullOrWhiteSpace(name))
        {
            HighscoreControl.SetHighscore(name, score);
            HighscoreUI.SetActive(false);
        }
        
    }
}
