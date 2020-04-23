using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    //Recuperar una referencia al componente rigidbody de este game object

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Puede ser null
        rb=GetComponent<Rigidbody>();

        //Podemos obtener varios si hay

        Rigidbody[] rbs=GetComponents<Rigidbody>();
        //rb.AddForce(new Vector3(0,5,-10),ForceMode.Impulse);
        rb.AddForce(transform.up*11,ForceMode.Impulse);
        Destroy(gameObject,3);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="COSO"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}