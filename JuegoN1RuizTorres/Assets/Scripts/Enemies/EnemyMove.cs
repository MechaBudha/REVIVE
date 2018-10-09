using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float minDist = 1;
    [SerializeField] private float maxDist = 10;

    private Transform target;
    [SerializeField] private Transform myTransform;
    [SerializeField] private AudioSource laugh;

	void Start(){
		target = FindObjectOfType<GameManager> ().GetPlayer ().transform;
	}

    void Update () {
        transform.LookAt(target);
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, target.position) >= minDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, target.position) <= maxDist )
            {
                /*Destroy(this.gameObject);
                laugh.Play();*/
            }

        }

        /*if (minDist > 6f)
            Debug.Log("Hola");*/
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { // check if it's the player, if you want
            Destroy(this.gameObject);
            laugh.Play();
        }
    }

    /*private void OnBecameVisible()
    {
        //Renderer.
        //Destroy(gameObject);
        Debug.Log("Hola");
    }*/
}
