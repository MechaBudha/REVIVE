using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    
    public Animator _animator;
    public bool doorIsOpening;
    //public GameObject secondEnemyObject;                            //Cuando esta en true activa el trigger
    public GameObject triggerObject;
    public GameObject triggerEnemy;
    public GameObject thisBox;
    public GameObject bgm1;
    public AudioSource bgm2;
    public AudioSource button;
    public GameObject trigger;

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
        //secondEnemyObject.SetActive(true);
        //secondEnemyObject.GetComponent<FirstChaseController>().enabled = true;
    }

    IEnumerator DeleteThisBox()
    {
        yield return new WaitForSeconds(0.5f);

        thisBox.SetActive(false);

        thisBox.GetComponent<DoorController>().enabled = false;

    }

}
