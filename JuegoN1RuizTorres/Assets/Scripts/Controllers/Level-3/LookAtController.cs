using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtController : MonoBehaviour {

    //[SerializeField] Transform target;
    [SerializeField] GameObject player;
    [SerializeField] Transform targetPoint;
    [SerializeField] float rotationDamping;
    [SerializeField] float movementSpeed;

    
    void Update () {

        Vector3 angles = transform.rotation.eulerAngles;
        Quaternion from = Quaternion.Euler(angles.x, angles.y, 0);

        Vector3 dir = targetPoint.position - transform.position;
        Quaternion to = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.RotateTowards(from, to, rotationDamping * Time.deltaTime);

        player.transform.position += player.transform.forward * Time.deltaTime * movementSpeed;
        //player.transform.position += player.transform.right * Time.deltaTime * movementSpeed;

    }
}
