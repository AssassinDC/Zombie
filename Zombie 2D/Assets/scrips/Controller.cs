using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject[] Sprite;
    PlayerStadistics vida;

    [Header("Sonido")]
    public Sonido sonido;

    [Header("Puntos")]
    [SerializeField] private float cantidadPuntos;
    private PlayerStadistics puntaje;

    



    private void Start()
    {
        vida = FindObjectOfType<PlayerStadistics>();

        puntaje = FindObjectOfType<PlayerStadistics>();

        /*if (cantidadPuntos <= 0)
        {
            cantidadPuntos = 0;
        }*/

        velocidadMove = (Random.Range(1f, 4f));

        damage = (Random.Range(1, 3));

    }

    
    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePaso].position, velocidadMove * Time.deltaTime);

        if(Vector2.Distance (transform.position, puntosMovimiento[siguientePaso].position) < distancia)
        {
            siguientePaso += 1;

           /*if (siguientePaso >= puntosMovimiento.Length)
            {
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }*/
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
            sonido.SonidoAudio();
        }
         
        if(actualDamage >= damage)
        {

            GetComponent<Collider2D>().enabled = false;
            velocidadMove = 0;

            Destroy(Sprite[1]);
            Sprite[0].SetActive(true);
            sonido.SonidoAudio();
            puntaje.SumarPuntos(cantidadPuntos);

            if (Sprite[0] == true)
            {
                Destroy(gameObject, 1f);
            }

            ;
        }
     }

    
    private void OnTriggerStay2D(Collider2D collision2D)
    {
        if(transform.tag == "Enemy" && collision2D)
        {
            Destroy(gameObject);
            vida.life--;
        }
    }


    private void OnBecameInvisible()
    {
        if (isHuman)
        {
            Destroy(gameObject);
        }
         

    }

    
}
