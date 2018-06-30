using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorController : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisDoor;
    [SerializeField] private AudioSource door;
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
        door.Play();

        StartCoroutine(DeleteThisButton());
    }

    IEnumerator DeleteThisButton()
    {
        yield return new WaitForSeconds(1.5f);
        thisDoor.GetComponent<OpenDoorController>().enabled = false;
        thisDoor.GetComponent<AudioSource>().enabled = false;
    }
}
