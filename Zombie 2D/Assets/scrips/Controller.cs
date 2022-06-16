using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("movimiento")]
    public float velocidadMove;
    [SerializeField]private Transform []puntosMovimiento;
    [SerializeField] private float distancia;
    private int siguientePaso = 0;

    [Header("Damage")]
    public bool isHuman;
    public int damage;
    int actualDamage;
    public PlayerStadistics vida;

    

    private void Start()
    {
        vida = FindObjectOfType<PlayerStadistics>();
       
    }

    
    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePaso].position, velocidadMove * Time.deltaTime);

        if(Vector2.Distance (transform.position, puntosMovimiento[siguientePaso].position) < distancia)
        {
            siguientePaso += 1;

            if (siguientePaso >= puntosMovimiento.Length)
            {
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
    private void Update()
    {
        Move();
    }

    

     private void OnMouseDown()
     {
        
        actualDamage++;
        if (isHuman)
        {
            vida.life--;
        }
         
        if(actualDamage >= damage)
        {
            Destroy(gameObject);
        }
        
     }
    
    private void OnBecameInvisible()
    {
        vida.life--;
        Destroy(gameObject);

    }

}
