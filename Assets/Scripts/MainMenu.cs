﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad = "MainLevel";

	public void Play ()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit ()
    {
        Debug.Log("Exciting!!");
        Application.Quit();
    }

    public void Credits ()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }




}
