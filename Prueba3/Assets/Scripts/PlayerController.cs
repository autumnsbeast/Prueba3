using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    public Text score;

    public Text highScoreText;

    public int puntaje;

    public int highScore = 0;



    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BasketBall"))
        {
            puntaje = puntaje+ 10;

            score.text = puntaje.ToString();

            highScore = puntaje;

        }

    }

    public void SetHighScore()
    {

        if (puntaje > highScore)
        {
            //highScoreText.text = highScore;

            highScore = puntaje;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.up * Time.deltaTime * -speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right* Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * Time.deltaTime * -speed;
        }

 

    }
}
