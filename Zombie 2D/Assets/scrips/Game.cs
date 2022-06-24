using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject canvasGameOver;
    public GameObject canvasInicio;


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
    //private bool estaPausado = false;

    






    private void Start()
    {
        //establecer la escal de tiempo original
        escalaDeTiempoInicial = escalaDeTiempo;

       /* //get the text component
        myText = GetComponent<Text>();*/

        //inicialmente la variable que acumular los tiempos de cada frame con el tiempo
        tiempoAmostrarEnsegundo = timeInicial;

        ActualizarReloj(timeInicial);
    }
    public void Setup (int life)
    {
        
        canvasGameOver.SetActive(true);
        //pointsText.text = life.ToString();
    }

    private void Update()
    {


        //la siguiente variable representa el tiempo de cada frame considerando la escala de tiempo
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;

        //la siguiente varieble va acumulando el tiempo trancurrido para luego mostrarlo en el reloj
        tiempoAmostrarEnsegundo += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAmostrarEnsegundo);

    }


    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
        canvasInicio.gameObject.SetActive(false);
        
    }

    public void PlayPlayyer()
    {
        SceneManager.LoadScene("Play");
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
