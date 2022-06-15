using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float velocidadMove;
    [SerializeField]private Transform []puntosMovimiento;
    [SerializeField] private float distancia;
    private int siguientePaso = 0;
    public GameObject enemy;
    public Life roborRojo;

    private void Start()
    {
        
       
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

    private void OnBecameInvisible()
    {
        Destroy(gameObject);

    }

    private void OnMouseDown()
    {
        
        Destroy(gameObject);
    }

}
