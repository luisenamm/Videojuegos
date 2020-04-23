using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    public GameObject original;
    public Transform referencia;
    private IEnumerator disparo;
    // Start is called before the first frame update
    void Start()
    {
        disparo=Disparar();
    }

    // Update is called once per frame
    void Update()
    {

         if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(disparo);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            StopCoroutine(disparo);
        }

        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");
        transform.Translate(h*5*Time.deltaTime,v*5*Time.deltaTime,0);

    }

 

    IEnumerator Disparar(){
        while(true){
            //Instanciar bala
            Instantiate(original,referencia.position,referencia.rotation);
            yield return new WaitForSeconds(0.2f);
            
        }
    }

}