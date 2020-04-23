using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public float velocidad=3;
    public Text textito;
    // Start is called before the first frame update
    void Start()
    {
       // textito.text="Hola mundo";
    }

    // Update is called once per frame
    void Update()
    {
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");

        transform.Translate(
            velocidad*h*Time.deltaTime,
            velocidad*v*Time.deltaTime,
            0,
            Space.World
        );
    }

    //Detección de colisiones
    // -los involucrados todos tienen collider
    // -uno (el que se mueve) tiene rigidbody

    //Si no congelamos hay una retroalimentación física
    void OnCollisionEnter(Collision c){
         print("Enter: "+c.transform.name);
         print("Mas info: "+c.contacts[0].point);
    }

    void OnCollisionStay(Collision c){
        print("Stay");
    }

    void OnCollisionExit(Collision c){
        print("Exit");
    }

    void OnTriggerEnter(Collider c){
        print("Trigger Enter: "+c.transform.name);
    }

    void OnTriggerStay(Collider c){
        // print("Trigger Stay");
    }

    void OnTriggerExit(Collider c){
        print("Trigger Exit");
    }
}
