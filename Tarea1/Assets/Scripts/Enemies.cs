using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemies : MonoBehaviour
{

    public Transform checkpoint1,
                    checkpoint2,
                    enemigo;
    public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        enemigo.position=checkpoint1.position;
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 dir=checkpoint2.position-enemigo.position;
            enemigo.Translate(dir.normalized*speed*Time.deltaTime,Space.World);
            enemigo.LookAt(checkpoint2);
        /*if(Vector3.Distance(enemigo.position,checkpoint2.position)<0.005){
            Vector3 dir=checkpoint1.position-enemigo.position;
            enemigo.Translate(dir.normalized*speed*Time.deltaTime,Space.World);
            enemigo.LookAt(checkpoint1);

        }*/
        

    }
}
