using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion2 : MonoBehaviour
{

    public GameObject bala;
    public Transform referencia;
    private IEnumerator disparar;
    // Start is called before the first frame update
    void Start()
    {
        disparar=Disparo();
    }

    // Update is called once per frame
    void Update()
    {

        
         if(Input.GetKeyDown(KeyCode.D)){
            StartCoroutine(disparar);
        }

         if(Input.GetKeyUp(KeyCode.D)){
            StopCoroutine(disparar);
        }

        float v=Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.W)){
            transform.Rotate(20*v*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Rotate(20*v*Time.deltaTime,0,0);
        }
    }

    IEnumerator Disparo(){
        while(true){
            //Instanciar bala
            Instantiate(bala,referencia.position,referencia.rotation);
            yield return new WaitForSeconds(0.2f);
            
        }
    }
}
