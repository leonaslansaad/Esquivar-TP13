using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float moveSpeed = 5f;

    
    private float[] positions = { -3f, 0f, 3f };

    private int currentPosition = 1; 

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate(3f,0,0);
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate(-3f,0,0);
        }

    }
}