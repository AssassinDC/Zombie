using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStadistics : MonoBehaviour
{
    [Header("Player")]
    public GameObject[] corazon;
    public Game gameOver;
    public int life = 3;

    private void Start()
    {
        life = corazon.Length;
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

        if(life < 1)
        {
            Destroy(corazon[2].gameObject);

        }
        else if (life <2)
        {
            Destroy(corazon[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(corazon[0].gameObject);
        }
    }

   /* public void Game()
    {
        //reperir
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
