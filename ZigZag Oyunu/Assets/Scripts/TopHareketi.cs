using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public float hýz;

    void Start()
    {
        yön = Vector3.forward;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(yön.x==0)
            {
                yön = Vector3.left;

            }
            else
            {
                yön= Vector3.forward;
            }
        }
        
    }

    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }
}
