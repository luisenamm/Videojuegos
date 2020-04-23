using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    public GameObject original;
    public Transform referencia;

    private Coroutine corutinita;
    private IEnumerator enumeradorcito,disparo;
    // Start is called before the first frame update
    void Start()
    {
        //original=GameObject.Find("Bala"); 

        enumeradorcito=pseudoHilo();

        corutinita=StartCoroutine(enumeradorcito);  
        
        //Fuchiwacala
        StartCoroutine("corutina2");

        disparo=Disparar();
    }

    // Update is called once per frame
    void Update()
    {
        //Crear un game object
        //Clonarlo-instantiate
        //Para instanciar necesitamos que el objeto base sea copia
        if(Input.GetKeyUp(KeyCode.Space)){
            StartCoroutine(disparo);
        }

         if(Input.GetKeyDown(KeyCode.Space)){
            StopCoroutine(disparo);
        }

        if(Input.GetKeyUp(KeyCode.C)){
            StopAllCoroutines();
        }
        if(Input.GetKeyUp(KeyCode.Z)){
            //Terminar pseudohilo
            //IEnumerator-coroutine
            StopCoroutine(enumeradorcito);
        }

        if(Input.GetKeyUp(KeyCode.X)){
            //Terminar corutina2
            StopCoroutine("corutina2");
        }

        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");
        transform.Translate(h*5*Time.deltaTime,0,0);
        transform.Rotate(10*v*Time.deltaTime,0,0);
    }

    //Corutinas
    //Pseudo concurrenicas
    //Regla general en las repeticiones
    //Hacer las menos posibles por segundo mientras se sienta bien
    //Se usan para no sobrecargar el update
    //Lo menos frecuente posibles
    IEnumerator pseudoHilo(){
        while(true){
            yield return new WaitForSeconds(0.5f);
            print("Hola");
        }
    }

    IEnumerator corutina2(){
        while(true){
            yield return new WaitForSeconds(0.3f);
            print("Adiós");
        }
    }

    IEnumerator Disparar(){
        while(true){
            //Instanciar bala
            Instantiate(original,referencia.position,referencia.rotation);
            yield return new WaitForSeconds(0.2f);
            
        }
    }
}
