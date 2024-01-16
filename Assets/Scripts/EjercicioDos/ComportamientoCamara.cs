using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class ComportamientoCamara : MonoBehaviour
{
    public LayerMask camino;
    public NavMeshAgent agente;
    public Ray ray;
    public RaycastHit hit;
    public GameObject destino;
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
      //siempre que quieras acceder a algo y no sepas el que ve a la interfas y busca el parametro en este caso por ejemplo el parametro es transform.
    }

    // Update is called once per frame
    void Update()
    {
        /* TODO: Lanzar un rayo al pulsar el botón, y modificar el destino de nuestro agente */
        if (Input.GetMouseButton(0))
        { 
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("hit");
            agente.destination = hit.point;
        }
        }
    }

}
