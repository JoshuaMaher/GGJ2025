using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty_cup : MonoBehaviour
{

    public GameObject Button;
    float currenttime;
    float rotation_speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;

        if (currenttime >= 6f)
            {
                Button.SetActive(true);
            }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotation_speed * Time.deltaTime, Space.Self);
        }
    }
}
