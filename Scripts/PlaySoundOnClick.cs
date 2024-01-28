using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioClip Boom;
    public AudioSource ausource;
    public float Volume;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playBoom() 
    {
        ausource.PlayOneShot(Boom, Volume);
    }
}
