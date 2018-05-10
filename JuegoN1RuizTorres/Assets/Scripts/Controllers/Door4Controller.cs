using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4Controller : MonoBehaviour
{

    public Animator _animator;
    public GameObject thisButton;
    //public GameObject trigger;
    public AudioSource button;

    public bool door4IsOpening;

    void Update()
    {

        if (door4IsOpening == true)
        {

            _animator.SetBool("open", true);

        }
    }


    public void OpenDoor4()
    {
        door4IsOpening = true;
        //trigger.SetActive(true);
        button.Play();

        StartCoroutine(DeleteThisButton());
    }

    IEnumerator DeleteThisButton()
    {
        yield return new WaitForSeconds(0.5f);

        //thisButton.SetActive(false);

        thisButton.GetComponent<Door4Controller>().enabled = false;

    }
}
