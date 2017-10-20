using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltar : MonoBehaviour {

    public Transform target1;
    public Transform target2;
    public Transform ball;
    public int fuerza;
    public bool salto;
    

    void Start()
    {

    }

    void Update()
    {
     if((ball== target1 || ball == target1)&&salto)
        {
            GetComponent<Rigidbody>().AddForce(0, fuerza, 0);
            salto = false;
        }
    }
}
