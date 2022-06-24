using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerStadistics : MonoBehaviour
{
   [Header("Player")]
    public GameObject[] corazon;
    public Game gameOver;
    public int life = 3;

    [Header("Score")]
    public float score;
    public TextMeshProUGUI textoScore;
    public GameObject hola;


    private void Start()
    {
        life = corazon.Length;
        //textoScore = GetComponent<TextMeshProUGUI>();
    }
    public void GameOver()
    {
        if (life <= 0)
        { 
            gameOver.Setup(life);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void Update()
    {
        GameOver();

         if (life < 1)
        {
            Destroy(corazon[2].gameObject);

        }
        else if (life < 2)
        {
            Destroy(corazon[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(corazon[0].gameObject);
        }

        //score += Time.deltaTime;
        textoScore.text = "Score: " + score.ToString("0");
    }


   public void SumarPuntos(float PuntosEntrada)
    {
        score += PuntosEntrada;
    }

    
   
}
