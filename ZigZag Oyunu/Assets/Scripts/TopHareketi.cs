using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 y�n;
    public float h�z;

    void Start()
    {
        y�n = Vector3.forward;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(y�n.x==0)
            {
                y�n = Vector3.left;

            }
            else
            {
                y�n= Vector3.forward;
            }
        }
        
    }

    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }
}
