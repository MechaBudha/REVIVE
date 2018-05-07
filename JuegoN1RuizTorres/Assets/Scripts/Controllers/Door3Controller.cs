using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3Controller : MonoBehaviour {

    public Animator _animator;
    public GameObject thisBox;
    public AudioSource _audioSource;
    //public AudioClip doorOpenSound;

    public bool doorIsOpening;
   
    void Update()
    {

        if (doorIsOpening == true)
        {
            _animator.SetBool("open", true);

            //GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        doorIsOpening = true;
        _audioSource.Play();

        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);

        thisBox.GetComponent<Door3Controller>().enabled = false;

    }
}
