using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour
{

    Transform target;
    [SerializeField] float distance;
    [SerializeField] float speed;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
		target = FindObjectOfType<GameManager> ().GetPlayer ().transform;
    }

    void Update()
    {
        Vector3 dirToMe = Vector3.Normalize(transform.position - target.position);
        Vector3 targetPos = target.position + dirToMe * distance;

        Vector3 dirToTarget = Vector3.Normalize(targetPos - transform.position);
        Vector3 movement = dirToTarget * speed * Time.deltaTime;

        float distToTarget = Vector3.Distance(targetPos, transform.position);
        movement = Vector3.ClampMagnitude(movement, distToTarget);

        transform.position += movement;

        anim.SetFloat("speed", distToTarget);
    }
}