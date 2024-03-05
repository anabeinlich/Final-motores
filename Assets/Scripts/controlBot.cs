using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class controlBot : MonoBehaviour

{
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;

    [SerializeField] private float inicialDelay;
    [SerializeField] private float findTargetRate;

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        InvokeRepeating("FindTarget", inicialDelay, findTargetRate);
        
    }


    void Update()
    {
       

    }

    private void FindTarget()
    {
        agent.destination = target.position;
    }
}
