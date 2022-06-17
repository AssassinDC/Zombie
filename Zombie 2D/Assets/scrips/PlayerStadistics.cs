using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStadistics : MonoBehaviour
{
    [Header("Player")]
    public Game gameOver;
    public int life = 3;
    

   public void GameOver()
    {
        if (life <= 0)
        { 
            gameOver.Setup(life);
            
        }
    }

    private void Update()
    {
        GameOver();
    }
}
