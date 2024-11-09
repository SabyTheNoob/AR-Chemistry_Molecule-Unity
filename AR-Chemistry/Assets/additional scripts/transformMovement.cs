using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformMovement : MonoBehaviour
{

    public Transform target;


    public Transform Subha;
    public SmoothFollow shubaa;

    void Start()
    {
        Subha=shubaa.target;
    }

    void Update()
    {
        //target.transform.position = transform.position;
        Subha.transform.position = transform.position;

    }
}
