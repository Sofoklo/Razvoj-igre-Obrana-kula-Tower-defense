﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

   

    public Text roundsText;


    void OnEnable()
    {
      

        roundsText.text = PlayerStats.Rounds.ToString();

    }


    


    public void Retry ()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu ()
    {
        
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Go to Menu!");
    }



}
