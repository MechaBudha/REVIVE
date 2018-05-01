using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    /*
        [SerializeField] private GameObject KeyDoor;
        public bool doorIsOpening;

        void Update () {
            if (doorIsOpening == true)
                KeyDoor.transform.Rotate(Vector3.up * Time.deltaTime * 10);
            if (KeyDoor.transform.rotation.y > 7f)
                doorIsOpening = false;
        }

        private void OnMouseDown()
        {
            doorIsOpening = true;
        }
        */

    public Animator _animator;
    public bool doorIsOpening;


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
    }

}
