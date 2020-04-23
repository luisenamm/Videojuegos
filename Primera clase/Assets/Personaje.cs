using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    //Atributos públicos
    //Parte del engine o primitivos
    //pueden ser modificados desde el editor
    public float velocidad=3;

     //Primer momento
    //sucede en el momento de la creación del componente
    //solo una vez
    void Awake(){
        //print("Awake");
    }

    // sucede una sola vez
    //después de todos los awakes
    //diferencias: start depende de que el objeto esté habilitado
    //start is called before the first frame update
    void Start()
    {
       //print("Start");    
    }


    // FPS - Frames per Second
    // Una vez por frame 
    // 30 fps - mínimo para considerar una aplicación tiempo real 
    // mínimo 60 fps
    // Update is called once per frame
    // Frecuencia con que corre es irregular
    // lo más magro posible
    // entrada del usuario
    // movimiento 
    void Update()
    {
        //print no bloquea la ejecución
        //print("Update");

        //Obtener input
        //polling y eventos
        //Aquí puro polling

        //2 maneras de tener entrada específicamente en Unity
        //1- preguntamente directamente al dispositiov
        //2- por medio de ejes

        if(Input.GetKeyDown(KeyCode.Space)){
            print("Key Down");
        }
        if(Input.GetKey(KeyCode.Space)){
            print("Key");
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            print("Key Up");
        }
        if(Input.GetMouseButtonUp(0)){
            print(Input.mousePosition);
        }
        
        //ejes- abstracción de la entrada de jugador
        //siempre están representados por un float
        //rango [-1,1]
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");

        //Podemos poner velocidad por frame pero el tamaño del frame es irregular
        //modificación: velocidad por segundo
        transform.Translate(velocidad*h*Time.deltaTime,velocidad*v*Time.deltaTime,0);
    }

    //En un frame
    //Después de correr TODOS los update
    //el motor corre TODOSl los LateUpdates

    // void LateUpdate(){
    //     //print("Late Update");
    // }

    //framerate fijo
    //configurable desde el editor

    // void FixedUpdate(){
    //     //print("Fixed Update");
    // }

}
