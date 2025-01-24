using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class Spponmoving : MonoBehaviour
{
    Transform dragging = null;
    Vector3 offset;

    public bool filled = false;
    [SerializeField] GameObject spoon;
    [SerializeField] GameObject cup;
    Collider2D SpoonCollider;
    Collider2D CupCollider;



    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, float.PositiveInfinity, LayerMask.GetMask("Spoon"));
            if (hit)
            {
                dragging = hit.transform;
                offset = dragging.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            dragging = null;
        }

        if (dragging != null)
        {
            dragging.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
}
