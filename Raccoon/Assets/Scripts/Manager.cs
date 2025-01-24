using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{

    public GameObject ticket, button;





    void Start()
    {
       
        ticket.SetActive(true);

    }


    void Update()
    {

       

    }

    public void Accept() 
    {
     ticket.SetActive(false);
     button.SetActive(false);
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

