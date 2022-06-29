using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    [Header("Game Over")]
    public GameObject canvasGameOver;
    PlayerStadistics codigoScore;
    public Text puntos;

    [Header("Inicio")]
    public GameObject canvasInicio;

    [Header("Pausa")]
    public GameObject canvasPausa;
    public GameObject botonPausa;
    private bool isPause;

    [Header("WIN")]
    public GameObject canvasWin;

    [Header("Reglas")]
    public GameObject canvasReglas;

    private void Start()
    {
        codigoScore = FindObjectOfType<PlayerStadistics>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }



    }
    public void MenuGameOver(float puntosDeEntradaa)
    {
        

        codigoScore.SumarPuntos(puntosDeEntradaa);

        puntos.text = "Score" + puntosDeEntradaa;
    }
    public void Pausa()
    {
        isPause = true;
        //canvasPausa = canvasPausa;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        canvasPausa.SetActive(true);
    }

    public void Reanudar()
    {
        isPause = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        canvasPausa.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Play");
    }

    public void RestartButton()
    {
        PlayerStadistics.score = 0;
        SceneManager.LoadScene("Game");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
        //canvasInicio.gameObject.SetActive(false);
        
    }

    public void PlayPlayyer()
    {
        SceneManager.LoadScene("Play");
    }

    public void Reglas()
    {
        SceneManager.LoadScene("Reglas");
    }

    public void SalirYaa()
    {
        Debug.Log("Cerrando");
        Application.Quit();
    }

}
