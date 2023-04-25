using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoscaCollision : MonoBehaviour
{
    public Vector3 initialPosition;
    public int lives;
     
    public TextMeshProUGUI textVidas;
    public TextMeshProUGUI txtScore;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        initialPosition = transform.position;
        textVidas.text = "Vidas: " + lives;
        txtScore.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ventilador")
        {
            //Destroy(gameObject);
            transform.position = initialPosition;
            lives--;
            textVidas.text = "Vidas: " + lives;
            if (lives==0)
            {
                PlayerDeath();
            }
        }
            else if (collision.gameObject.name == "Target")
        {
            Destroy(collision.gameObject);
            score++;
            txtScore.text = score.ToString();
        }

    }
    void PlayerDeath()
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        
    }
}
