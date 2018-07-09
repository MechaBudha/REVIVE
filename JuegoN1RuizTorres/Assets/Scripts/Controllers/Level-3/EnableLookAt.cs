using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLookAt : MonoBehaviour {

    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<LookAtController>().enabled = true;

    }
}
