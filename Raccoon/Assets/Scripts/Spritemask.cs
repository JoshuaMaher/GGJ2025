using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritemask : MonoBehaviour
{
    public GameObject Button;
    float currenttime = 0f;
    public GameObject manager;
    public GameObject liquid;
    // Start is called before the first frame update
    [SerializeField] private AudioSource milkSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            currenttime += Time.deltaTime;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, float.PositiveInfinity, LayerMask.GetMask("Button"));

            if (currenttime >= 6f && manager.GetComponent<Manager>().orderaccepted == true && hit)
            {
                Button.SetActive(true);
            }
            
        if (manager.GetComponent<Manager>().orderaccepted == true && hit && Input.GetKeyDown(KeyCode.Mouse0))
        {
                milkSound.Play();
                liquid.SetActive(true);
        }
                if (Input.GetKeyUp(KeyCode.Mouse0))
        {
                milkSound.Stop();
                liquid.SetActive(false);
        }
        if (manager.GetComponent<Manager>().orderaccepted == true && hit && Input.GetKey(KeyCode.Mouse0) ) 
        {

                this.transform.position += new Vector3(0, 0.0025f, 0);
        }
    }
}
