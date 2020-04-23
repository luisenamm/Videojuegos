using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject original;
    public Transform referencia;
    private IEnumerator disparo;
    public float targetTime = 2.0f;

    bool bandera=true;
    void Start()
    {
         disparo=Disparar();
    }
    // Update is called once per frame
    void Update()
     {
        targetTime = targetTime-Time.deltaTime;
        print(targetTime);
        
       if (targetTime <= 0.0f)
        {   
            bandera=false;
            StartCoroutine(disparo); 
            if(bandera==false){
               targetTime = 2.0f; 
            }
            
        }
 
    }
    
    void timerEnded(){
    //do your stuff here.
    StartCoroutine(disparo); 
    }

     IEnumerator Disparar(){
        while(true){
            //Instanciar bala
            
            Instantiate(original,referencia.position,referencia.rotation);
            yield return new WaitForSeconds(0.2f);
            StopCoroutine(disparo); 
        }
    }
}