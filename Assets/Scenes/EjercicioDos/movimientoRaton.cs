using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimientoRaton : MonoBehaviour
{
    public LayerMask suelo;
    public NavMeshAgent navi;
    public Ray rayo;
    public RaycastHit golpe;

    // Start is called before the first frame update
    void Start()
    {
          
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            
                if (Physics.Raycast(rayo,out golpe))
                        {
                            navi.destination = golpe.point;
                        }
        }
        
    }
}
