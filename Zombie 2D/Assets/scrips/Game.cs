using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject canvasGameOver;
    public GameObject canvasInicio;

    //public Text pointsText;

   
    public void Setup (int life)
    {
        
        canvasGameOver.SetActive(true);
        //pointsText.text = life.ToString();
    }

    private void Update()
    {
       /* if (canvasInicio == true && Input.GetKeyDown(KeyCode.X))
        {
            canvasInicio.gameObject.SetActive(false);
        }*/
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

   


}
