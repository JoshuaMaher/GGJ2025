using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Mixing : MonoBehaviour
{

    public GameObject liquid;
    float filltime = 50f;
    float currenttime;
    Collider2D CupCollider;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesHitTriggers = true;
        CupCollider = this.GetComponent<Collider2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

            for (int i = 0; i < 10; i++)
            {
                if (currenttime <= filltime)
                {
                    currenttime += Time.deltaTime;
                    new WaitForSeconds(0.01f);
                    Debug.Log(currenttime);
                }
                else
            {
                collision.gameObject.GetComponent<Spponmoving>().filled = true;
                liquid.SetActive(false);
            }

            

        }
    }
}
