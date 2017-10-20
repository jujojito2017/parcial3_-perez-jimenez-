using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    public Transform target1;
    public Transform target2;
    public float rapidez;


    void Start()
    {

    }

    void Update()
    {
        float velocidad = rapidez * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target1.position, velocidad);

    }
}
