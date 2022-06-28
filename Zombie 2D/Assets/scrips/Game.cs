using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [Header("Game Over")]
    public GameObject canvasGameOver;

    [Header("Inicio")]
    public GameObject canvasInicio;

    [Header("Pausa")]
    public GameObject canvasPausa;
    public GameObject botonPausa;
    private bool isPause;
    private void Start()
    {
       
    }
    /*public void Setup (int life)
    {
        SceneManager.LoadScene("GameOver");
        //pointsText.text = life.ToString();
    }*/

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

    public void SalirYaa()
    {
        Debug.Log("Cerrando");
        Application.Quit();
    }

}
