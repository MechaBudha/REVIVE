using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    
    public Animator _animator;
    public bool doorIsOpening;
    public GameObject secondEnemyObject;                            //Cuando esta en true activa el trigger

    void Start()
    {
        
    }

    void Update()
    {

        if (doorIsOpening == true)
        {

            _animator.SetBool("open", true);
            
        }
    }


    void OnMouseDown()
    {
        doorIsOpening = true;
        secondEnemyObject.SetActive(true);
        secondEnemyObject.GetComponent<FirstChaseController>().enabled = true;
    }

}
