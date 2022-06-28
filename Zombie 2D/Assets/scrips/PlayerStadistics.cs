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


    [Header("Tiempo")]
    [Tooltip("Tiempo inicial en segundos")]
    public float timeInicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;

    public Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAmostrarEnsegundo = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;

    

    private void Start()
    {

        //establecer la escal de tiempo original
        escalaDeTiempoInicial = escalaDeTiempo;

        //inicialmente la variable que acumular los tiempos de cada frame con el tiempo
        tiempoAmostrarEnsegundo = timeInicial;

        life = corazon.Length;
        ActualizarReloj(timeInicial);
        //textoScore = GetComponent<TextMeshProUGUI>();
    }
    public void GameOver()
    {
        if (life <= 0)
        {

            SceneManager.LoadScene("GameOver");
            //gameOver.Setup(life);
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

        //la siguiente variable representa el tiempo de cada frame considerando la escala de tiempo
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;

        //la siguiente varieble va acumulando el tiempo trancurrido para luego mostrarlo en el reloj
        tiempoAmostrarEnsegundo += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAmostrarEnsegundo);

        //score += Time.deltaTime;
        textoScore.text = "Score: " + score.ToString("0");
    }


   public void SumarPuntos(float PuntosEntrada)
    {
        score += PuntosEntrada;
    }


    public void ActualizarReloj(float tiempoEnsegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        //Asegurar que el tiempo no sea negativo
        if (tiempoEnsegundos < 0)
        {
            tiempoEnsegundos = 0;
        }
        //Calcular minutos y segundos
        minutos = (int)tiempoEnsegundos / 60;
        segundos = (int)tiempoEnsegundos % 60;

        //crear la cadena de caracterizticas con dos digitos para los minutos y segundos, separados por ":"
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        //actualizar el elemento de text de ui con la cadena de caracteres
        myText.text = textoDelReloj;

    }
}
