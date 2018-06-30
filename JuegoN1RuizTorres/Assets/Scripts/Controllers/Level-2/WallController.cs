using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject thisWall;
    //[SerializeField] private GameObject trigger;
    //[SerializeField] private AudioSource wall;
    [SerializeField] private bool wallIsOpening;

    void Update()
    {
        if (wallIsOpening == true)
        {
            _animator.SetBool("open", true);
        }
    }

    public void OpenWall()
    {
        wallIsOpening = true;
        //trigger.SetActive(true);
        //wall.Play();

        StartCoroutine(DeleteThisWall());
    }

    IEnumerator DeleteThisWall()
    {
        yield return new WaitForSeconds(0.5f);

        //thisButton.SetActive(false);

        thisWall.GetComponent<WallController>().enabled = false;

    }
}