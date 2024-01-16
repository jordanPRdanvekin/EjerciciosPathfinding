using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Hay que incluir esta dependencia!
using UnityEngine.AI;

public class MovimientoAgente : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destino;
    public Vector3 inicio;
    void Start()
    {
        /* TODO: Obtener una referencia al agente, y establecer como destino las coordenadas del objeto 'Premio' */
        agent = GetComponent<NavMeshAgent>();
        agent.destination = destino.transform.position;
    }

    // ¿Hace falta poner el Update? 
    //si, hace falta añadir un bucle que haga que al llegar a destino vuelva a inicio y de inicio vuelva a destino.
    void Update()
    {
        Debug.Log("mis coordenadas" + transform.position + "las coordenadas del destino" + destino.position);
        //si la posicion en el eje x y z es igual a las de el destino tendremos que modificar al agente para que el nuevo destino sea el inicial. 
        Debug.Log(transform.position);
    }
}
