using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMazeController : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisButton;
    [SerializeField] private AudioSource button;
    [SerializeField] private AudioSource bm1;
    [SerializeField] private AudioSource bm2;
    [SerializeField] private bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            _animator.SetBool("open", true);
        }
    }


    public void OpenDoor()
    {
        doorIsOpening = true;
        //trigger.SetActive(true);
        button.Play();
        bm1.Play();

        StartCoroutine(DeleteThisButton());
        StartCoroutine(DeleteThisMusic());
    }

    IEnumerator DeleteThisButton()
    {
        yield return new WaitForSeconds(0.5f);
        thisButton.GetComponent<DoorMazeController>().enabled = false;
    }

    IEnumerator DeleteThisMusic()
    {
        yield return new WaitForSeconds(220f);
        bm1.GetComponent<AudioSource>().enabled = false;
        bm2.Play();
        //thisButton.GetComponent<DoorMazeController>().enabled = false;
    }
}
