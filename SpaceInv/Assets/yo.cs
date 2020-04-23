using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yo : MonoBehaviour
{
    public float velocidad=5f;
    int dir;
    public float positiony=0f;
    public int speed=6;

    public GameObject player;

    public int bandera = 8;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x >-24 || bandera>10){  
            dir = -2;
        }
        if(transform.position.x< -23){
            bandera=-10;
            transform.position = player.transform.position - Vector3.up /2;
        }
        if(transform.position.x> 23){
            bandera=11;
           //transform.position = player.transform.position + Vector3.up * 2;
           transform.position = player.transform.position - Vector3.up / 2;
        }
        if(bandera<-9 ){
            dir = 2;
        }
        transform.Translate( Time.deltaTime * dir * speed,0,0);
        
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="yo"){
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
         if(collision.gameObject.tag=="PISO"){
            Destroy(gameObject);
             Time.timeScale = 0;
        }
    }
}