using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisWall;
    //[SerializeField] private GameObject trigger;
    [SerializeField] private AudioSource gate;
    [SerializeField] private bool wallIsOpening;
    //[SerializeField] private bool makeSound = false;

    void Update()
    {
        if (wallIsOpening == true)
        {
            _animator.SetBool("open", true);
           // makeSound = true;
        }
    }

    public void OpenWall()
    {
        //makeSound = false;
        wallIsOpening = true;
        //trigger.SetActive(true);
        //wall.Play();
        //if (makeSound == true)
            gate.Play();

        StartCoroutine(DeleteThisWall());
    }

    IEnumerator DeleteThisWall()
    {
        yield return new WaitForSeconds(7f);

        //thisButton.SetActive(false);

        thisWall.GetComponent<WallController>().enabled = false;

    }
}