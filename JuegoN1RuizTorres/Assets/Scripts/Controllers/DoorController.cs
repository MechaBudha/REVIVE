using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    [SerializeField] private Animator _animator;
    [SerializeField] private bool doorIsOpening;
    //[SerializeField] private GameObject secondEnemyObject;                            //Cuando esta en true activa el trigger
    [SerializeField] private GameObject triggerObject;
    [SerializeField] private GameObject triggerEnemy;
    [SerializeField] private GameObject thisBox;
    [SerializeField] private GameObject bgm1;
    [SerializeField] private AudioSource bgm2;
    [SerializeField] private AudioSource button;
    [SerializeField] private GameObject trigger;
    [SerializeField] private GameObject radio2;

    void Update()
    {
        if (doorIsOpening == true)
        {
            _animator.SetBool("open", true);
            StartCoroutine(DeleteThisBox());
        }
    }


    public void OpenKeyDoor()
    {
        doorIsOpening = true;

        triggerObject.GetComponent<LightsController>().enabled = true;
        triggerEnemy.SetActive(true);
        bgm1.SetActive(false);
        bgm2.Play();
        button.Play();
        trigger.SetActive(true);
        radio2.SetActive(true);
        //secondEnemyObject.SetActive(true);
        //secondEnemyObject.GetComponent<FirstChaseController>().enabled = true;
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        //thisBox.SetActive(false);

        thisBox.GetComponent<DoorController>().enabled = false;

    }

}
