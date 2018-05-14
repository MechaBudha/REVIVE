using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3Controller : MonoBehaviour {

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisBox;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioSource _audioSource2;
    //[SerializeField] private AudioClip doorOpenSound;

    [SerializeField] private bool doorIsOpening;
   
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
        _audioSource2.Play();

        StartCoroutine(DeleteThisBox());
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);

        thisBox.GetComponent<Door3Controller>().enabled = false;

    }
}
