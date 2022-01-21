using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public LayerMask clickableground;
    private NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayHit = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayHit, out hitInfo, 100, clickableground))
            {
                navAgent.SetDestination(hitInfo.point);
            }

        }








    }



}
