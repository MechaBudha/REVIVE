using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class JumpScareController : MonoBehaviour {

    public AudioSource _audioSource;
    public GameObject enemy;
    public GameObject jumpBox;
    public GameObject playerObject;

    public bool triggerOn;

    void Update()
    {
        if(triggerOn)
        {
            //_audioSource.PlayOneShot(piano);
            //_audioSource.clip = piano;


            enemy.SetActive(true);

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        triggerOn = true;
        _audioSource.Play();
        playerObject.GetComponent<FirstPersonController>().enabled = false;

        StartCoroutine(EndJumpScare());
    }

    IEnumerator EndJumpScare()
    {
        yield return new WaitForSeconds(4.2f);
        enemy.SetActive(false);
        jumpBox.SetActive(false);


        jumpBox.GetComponent<JumpScareController>().enabled = false;
        _audioSource.GetComponent<AudioSource>().enabled = false;
        playerObject.GetComponent<FirstPersonController>().enabled = true;
    }
}
