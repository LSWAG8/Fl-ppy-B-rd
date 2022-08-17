using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class MainMenuControl : MonoBehaviour
{
    public HighscoreControl highscoreControl;
    
    public GameObject StartMenuUI;
    
    private void Start()
    {
        
    }


    public void SpielBeenden()
    {
        if (Application.isEditor)
        {
            EditorApplication.isPlaying = false;
        }

        else
        {
            Application.Quit();
        }
    }

    public void SpielStarten()
    {
        SceneManager.LoadScene("Game");
    }

   

   

    


}
