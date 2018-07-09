using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtController : MonoBehaviour {


    //[SerializeField] Transform target;
    [SerializeField] Transform targetPoint;
    [SerializeField] float rotationDamping;

    void Update () {
        //transform.LookAt(target);

        /*
        Vector3 dir = targetPoint - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, lookRotation, rotationDamping * Time.deltaTime);
        transform.rotation = newRotation;
        */

        Vector3 angles = transform.rotation.eulerAngles;
        Quaternion from = Quaternion.Euler(angles.x, angles.y, 0);

        Vector3 dir = targetPoint.position - transform.position;
        Quaternion to = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.RotateTowards(from, to, rotationDamping * Time.deltaTime);

        
    }
}
