using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class HighscoreControl : MonoBehaviour
{

    

    public bool HighscoreCheck(int score)
    {
        if(PlayerPrefs.GetInt("highscore") < score )
        {
            return true;
        }

        return false;
    }

    public void SetHighscore(string name, int score)
    {
        PlayerPrefs.SetString("highscorer", name);
        PlayerPrefs.SetInt("highscore", score);
    }



    

}
