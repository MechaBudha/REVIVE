using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMazeController : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisButton;
    [SerializeField] private AudioSource button;
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

        StartCoroutine(DeleteThisButton());
    }

    IEnumerator DeleteThisButton()
    {
        yield return new WaitForSeconds(0.5f);
        thisButton.GetComponent<DoorMazeController>().enabled = false;
    }
}
