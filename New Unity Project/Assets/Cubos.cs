using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    public GameObject[] cubos;
    public GameObject clon;
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        cubos = new GameObject[5];
        for (int i = 0; i < cubos. Length; i++)
        {
          cubos[i] = Instantiate(clon);
          cubos[i].transform.Translate(1, 0, 0);
        }
        {
         
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            cubos[n] = Instantiate(clon);
            cubos[n].GetComponent<Renderer>().material.color = Color.blue;
          

        }
    }
}
