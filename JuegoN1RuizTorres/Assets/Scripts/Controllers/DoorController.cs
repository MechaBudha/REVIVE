using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    
    public Animator _animator;
    public bool doorIsOpening;
    //public GameObject secondEnemyObject;                            //Cuando esta en true activa el trigger
    public GameObject triggerObject;
    public GameObject thisBox;

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
