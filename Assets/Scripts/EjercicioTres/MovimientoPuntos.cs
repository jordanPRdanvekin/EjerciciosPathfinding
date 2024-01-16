using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] listaVectores ;
    public float stopdistance = 0.1f; 
    public NavMeshAgent agente;

    public int actual = 0;

    private void Start()
    {
       /* TODO: Crear la lista de puntos (se puede hacer por código o desde la UI*/
       /* TODO: Establecer el primer punto como destino */
       agente = GetComponent<NavMeshAgent>();
       SetNextPatrolDestination();
    }

   
    // Update is called once per frame
    void Update()
    {
       if(agente.remainingDistance < stopdistance)
        {
            Debug.Log("Estamos cerca");
            SetNextPatrolDestination();
        }
      
    }
    
    private void SetNextPatrolDestination()
    {
        agente.SetDestination(listaVectores[actual]);

  
        actual = (actual + 1) % listaVectores.Length;
        // modificar el destino del agente
    }

}
