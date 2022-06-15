using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject []zombie;
    public Transform []spawnn;
    void Spawn()
    {
        int EnemyRandum = Random.Range(0, zombie);
        
    }
}
