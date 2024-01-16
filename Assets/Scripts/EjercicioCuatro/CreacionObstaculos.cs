using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class CreacionObstaculos : MonoBehaviour
{
    public NavMeshSurface superficie;
    public GameObject obstaculo;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(obstaculo, hit.point, Quaternion.identity);
            }
        }
        
    }
       
}
