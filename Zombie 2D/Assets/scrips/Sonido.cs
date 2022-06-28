using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip sonido;
    public float volumen = 1;

    public void SonidoAudio()
    {
        AudioSource.PlayClipAtPoint(sonido, gameObject.transform.position, volumen);
    }
}
