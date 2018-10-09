using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour {

   private Transform target;

	void Start(){
		target = FindObjectOfType<GameManager> ().GetPlayer ().transform;
	}
    void Update()
    {
        Vector3 dir = Vector3.Normalize(target.position - transform.position);
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
