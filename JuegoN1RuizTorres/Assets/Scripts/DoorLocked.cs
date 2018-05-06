using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour {

    [SerializeField] private GameObject Door;
    [SerializeField] private AudioClip doorLockedSound;

    public void TryToOpen()
    {
        GetComponent<AudioSource>().PlayOneShot(doorLockedSound);
    }
}
