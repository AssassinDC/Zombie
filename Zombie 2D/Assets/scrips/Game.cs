using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject canvasGameOver;

    //public Text pointsText;
   public void Setup (int life)
    {
        
        canvasGameOver.SetActive(true);
        //pointsText.text = life.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    
}
