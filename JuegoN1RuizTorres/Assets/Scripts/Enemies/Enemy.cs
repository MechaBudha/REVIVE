using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    [SerializeField] private float deathDistance = 0.5f;
    [SerializeField] private float distanceAway;
    [SerializeField] private Transform thisObject;
    [SerializeField] private Transform target;
    [SerializeField] private AudioSource laugh;
    private NavMeshAgent navComponent;

	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        float dist = Vector3.Distance(target.position, transform.position);

        if (target)
            navComponent.SetDestination(target.position);
        else
        {
            if (target = null)
                target = this.gameObject.GetComponent<Transform>();
            else
                target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        if(dist <= deathDistance)
        {
            Destroy(thisObject);
            laugh.Play();
        }
	}
}
