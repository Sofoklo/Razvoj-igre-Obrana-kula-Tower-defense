using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour {

    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject wavespawner;
    public float waitTime = 2f;

    void Update ()
    {
        
       
            for (int i = 0; i < popUps.Length; i++)
            {
                if(i == popUpIndex)
                {
                    popUps[i].SetActive(true);
                }else
                {
                    popUps[i].SetActive(false);
                }
            }

        if (popUpIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                popUpIndex++;
            }
        }else if (popUpIndex == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }
        }else if (popUpIndex == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }
        }else if (popUpIndex == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }
        }else if (popUpIndex == 4)
        {
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }
        }else if (popUpIndex == 5)
        {
            if(waitTime <= 0)
            {
                SceneManager.LoadScene("MainLevel");
            }else
            {
                waitTime -= Time.deltaTime;
            }

            
        }
    }
}
