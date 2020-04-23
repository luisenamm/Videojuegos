using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navegador : MonoBehaviour
{
    private NavMeshAgent agente;
    // Start is called before the first frame update
    void Start()
    {
        agente=GetComponent<NavMeshAgent>();
        agente.destination=Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
