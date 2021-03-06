using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject [] Enemy;

    public float timeSpawn = 1;
    public float repeatSpawnRate = 3;

    public Transform xRangeRight;
    public Transform xRangeleft;

    public Transform yRangeUp;
    public Transform yRangeDown;

    [Header("Dificultad")]
    public float contador = 0f;
    public float curva = 30f;

    int cantidad = 2;

    private void Start()
    {
        // InvokeRepeating("Spawn", timeSpawn, repeatSpawnRate);
        Spawn(2);
    }
    
    public void Spawn(float cantidad)
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        
        for (int i = 0; i < cantidad; i++)
        {
            spawnPosition =new Vector3 (Random.Range(xRangeleft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y),0);
              GameObject enemy = Instantiate(Enemy[Random.Range(0, Enemy.Length)], spawnPosition,gameObject.transform.rotation);
        }

          

        
    }
    private void Update()
    {
        //Spawn();
        
        contador += Time.deltaTime;
        if (contador >= curva)
        {
            
            timeSpawn = timeSpawn - 0.5F;
            repeatSpawnRate = repeatSpawnRate - 0.5f;
            contador = 0;


            // InvokeRepeating("Spawn", timeSpawn, repeatSpawnRate);
            Spawn(cantidad);
            cantidad += 2;
        }
    }
}
