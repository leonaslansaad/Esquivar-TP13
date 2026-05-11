using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    public float speed = 3f;
    public int limite = 2;
    private int carrilactual = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed * Time.deltaTime,0);
    }
}
