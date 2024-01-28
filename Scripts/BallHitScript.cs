using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource source;
    public AudioClip BOUNCE, hit, goal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("TOPBOTWALL")) 
        {
            source.PlayOneShot(BOUNCE, 1);
        }


        if (collision.transform.CompareTag("PAD")) 
        {
            source.PlayOneShot(hit, 1.5f);
        }

        if (collision.transform.CompareTag("GOAL")) 
        {
            source.PlayOneShot(goal, 1);
        }
    }
}
