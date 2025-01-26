using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCup : MonoBehaviour
{
    float currenttime;
    float rotation_speed = -60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotation_speed * Time.deltaTime, Space.Self);
        }
    }
}
