using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Mixing : MonoBehaviour
{

    public GameObject cup;
    float mixCount = 7;

    public bool mixed;
    private bool soundPlayed;

    Color ogColor;

    [SerializeField] private AudioSource slosh;
    [SerializeField] private AudioSource win;



    void Start()
    {
        Physics2D.queriesHitTriggers = true;
        ogColor = cup.gameObject.GetComponent<SpriteRenderer>().color;
       
    }

    void Update() 
    {
        if (mixCount <=0) 
        {
              cup.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
              cup.gameObject.GetComponent<BoxCollider2D>().enabled = false;
              mixed = true;
        }

        if(mixed && !soundPlayed) 
        {
            StartCoroutine(Finished());
        }
    }

    IEnumerator Finished() 
    {
         soundPlayed = true;
         win.Play();

        yield return new WaitForSeconds(2);

        win.Stop();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cup")) 
        {
            mixCount -= 1;
            cup.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            slosh.Play();
        }            

        
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
         if(collision.gameObject.CompareTag("Cup")) 
        {
            cup.gameObject.GetComponent<SpriteRenderer>().color = ogColor;
        }      
    }
}
