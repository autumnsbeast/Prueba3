using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public Text timerText;

    public Text gameOver;

    public Text gameOverText;

    public float timeLeft = 30.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "TIEMPO:" + " " + timeLeft.ToString("00");

        if (timeLeft < 0)
        {
           
            gameOver.enabled = true;

            gameOverText.enabled = true;

            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }


        }

    }
}
    

