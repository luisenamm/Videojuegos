using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo : MonoBehaviour
{

    public float F{
        get{
            return g+h;
        }
    }
    public float g,h;

    public Nodo[] vecinos;
    public List<Nodo> historial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos(){
    
        //Cuando dibujemos en gizmos hay que poner el color primero y luego mandamos a hacer el dibujo
        Gizmos.color=Color.blue;
        Gizmos.DrawSphere(transform.position,1);

        Gizmos.color=new Color(255,157,0);

        for(int i=0;i<vecinos.Length;i++){
            Gizmos.DrawLine(transform.position,vecinos[i].transform.position);    
            
        }
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 1);
    }


}
