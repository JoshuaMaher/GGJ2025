using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{

    [SerializeField] private AudioSource buttonSound;

    public GameObject ticket, cup, spoon, machine, bobaButton, redline, mixButton, bobaCup, smallCup, liquid;

    public bool filled, orderaccepted;

    public GameObject greenCircle;





    void Start()
    {
       
        ticket.SetActive(true);

    }


    void Update()
    {

       if (filled) 
       {
         spoon.SetActive(true);
       }


      
    }

    public void Accept() 
    {
     ticket.SetActive(false);
     buttonSound.Play();
     cup.SetActive(true);
     machine.SetActive(true);
     liquid.SetActive(true);

     StartCoroutine(Flash());
     
     orderaccepted = true;
     
    
    }


    public void Mix() 
    {
       
        mixButton.SetActive(false);
        spoon.SetActive(true);
        smallCup.SetActive(false);
        

    }

    public void Boba() 
    {
        redline.SetActive(false);
        machine.SetActive(false);
        bobaButton.SetActive(false);
        bobaCup.SetActive(true);
    }


     IEnumerator Flash() 
       {
         greenCircle.SetActive(false);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(true);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(false);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(true);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(false);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(true);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(false);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(true);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(false);

         yield return new WaitForSeconds(0.2f);

         greenCircle.SetActive(true);

        
       }

    
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

