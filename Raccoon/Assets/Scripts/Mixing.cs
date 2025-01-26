using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Mixing : MonoBehaviour
{

    public GameObject Liquid, straw, ticket, endcup, cup, ice, boba, firework;
    float mixCount = 7;


    public bool mixed;
    private bool soundPlayed;

    Color ogColor;

    [SerializeField] private AudioSource slosh;
    [SerializeField] private AudioSource win;



    void Start()
    {
        Physics2D.queriesHitTriggers = true;
        ogColor = Liquid.gameObject.GetComponent<SpriteRenderer>().color;
       
    }

    void Update() 
    {
        if (mixCount <=0) 
        {
            
            Liquid.gameObject.GetComponent<BoxCollider2D>().enabled = false;
              
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
         firework.SetActive(true);

        yield return new WaitForSeconds(1.7f);

        win.Stop();

        straw.SetActive(false);

        ticket.SetActive(true);
        cup.SetActive(false);
        endcup.SetActive(true);
        Liquid.SetActive(true);
        ice.SetActive(false);
        boba.SetActive(false);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cup")) 
        {
            mixCount -= 1;
            Liquid.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            slosh.Play();
        }            

        
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
         if(collision.gameObject.CompareTag("Cup")) 
        {
            Liquid.gameObject.GetComponent<SpriteRenderer>().color = ogColor;
        }      
    }
}
