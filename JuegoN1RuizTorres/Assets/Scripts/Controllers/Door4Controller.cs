using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4Controller : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisButton;
    //[SerializeField] private GameObject trigger;
    [SerializeField] private AudioSource button;
    [SerializeField] private bool door4IsOpening;

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
