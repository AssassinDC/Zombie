using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEnemy : MonoBehaviour
{
    public int life;
    


    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        life++;
        
        if (life >= 2)
        {
            Destroy(gameObject);
            
        }

        
    }

}
