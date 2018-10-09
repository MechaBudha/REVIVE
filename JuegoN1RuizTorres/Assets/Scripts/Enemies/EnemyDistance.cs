using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour
{

    Transform target;
    [SerializeField] float distance;
    [SerializeField] float speed;
    //[SerializeField] float distanceMin;
    //[SerializeField] float distanceMax;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
		target = FindObjectOfType<GameManager> ().GetPlayer ().transform;
    }

    void Update()
    {
        /*
        Vector3 diff = target.position - transform.position;
        Vector3 dir = diff.normalized;
        float dist = diff.magnitude;

        if (dist < distanceMin)
        {
            transform.position -= dir * speed * Time.deltaTime;
            anim.SetFloat("speed", (dist - distanceMax));
        } else if (dist > distanceMax)
                {
                    transform.position += dir * speed * Time.deltaTime;
                    anim.SetFloat("speed", (dist - distanceMax));
                }
        else
        {
            anim.SetFloat("speed", 0f);
        }
        */
        //Calculo una posición que esté alejada del atarget
        Vector3 dirToMe = Vector3.Normalize(transform.position - target.position);
        Vector3 targetPos = target.position + dirToMe * distance;

        //Calculo la dirección hacia el target y con eso cuanto deberia moverme
        Vector3 dirToTarget = Vector3.Normalize(targetPos - transform.position);
        Vector3 movement = dirToTarget * speed * Time.deltaTime;

        //Calculo la distancia hacia el target y limito el vector de movimiento
        //para que no sea mayor a dicha distancia, o sea, que no se pase
        float distToTarget = Vector3.Distance(targetPos, transform.position);
        movement = Vector3.ClampMagnitude(movement, distToTarget);

        //Aplico el movimiento luego de limitarlo
        transform.position += movement;

        anim.SetFloat("speed", distToTarget);
    }
}