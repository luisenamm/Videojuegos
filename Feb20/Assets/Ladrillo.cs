using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillo : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E)){
            rb.AddExplosionForce(1000,
            new Vector3(7.1f, 3.4586f,-10.25177f),
            0);
        }
    }
}
