using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4Controller : MonoBehaviour
{

    public Animator _animator;
    public GameObject thisButton;

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

        StartCoroutine(DeleteThisButton());
    }

    IEnumerator DeleteThisButton()
    {
        yield return new WaitForSeconds(3f);

        thisButton.SetActive(false);

        thisButton.GetComponent<Door4Controller>().enabled = false;

    }
}
