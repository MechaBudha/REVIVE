using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractController : MonoBehaviour {

    [SerializeField] private string interactButton;
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private LayerMask interactLayer;         //Filtro para que no se pueda interactuar con todo
    [SerializeField] private Image interactIcon;
    [SerializeField] private bool isInteracting;

	// Use this for initialization
	void Start () {

        if(interactIcon != null)
            interactIcon.enabled = false;
	}
	
	void Update () {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, interactDistance, interactLayer))
        {
            if(!isInteracting)
            {
                if(interactIcon != null)
                    interactIcon.enabled = true;

                if(Input.GetButtonDown(interactButton))
                {
                    if(hitInfo.collider.CompareTag("Note"))
                    {
                        hitInfo.collider.GetComponent<NotesController>().ShowNoteImage();
                    }

                    if (hitInfo.collider.CompareTag("Key2"))
                    {
                        hitInfo.collider.GetComponent<KeyDoor2Controller>().PickUp();
                    }

                    if (hitInfo.collider.CompareTag("Button"))
                    {
                        hitInfo.collider.GetComponent<Door4Controller>().OpenDoor4();
                    }

                    if (hitInfo.collider.CompareTag("Door"))
                    {
                        hitInfo.collider.GetComponent<DoorLocked>().TryToOpen();
                    }

                    if (hitInfo.collider.CompareTag("ButtonKey"))
                    {
                        hitInfo.collider.GetComponent<DoorController>().OpenKeyDoor();
                    }

                    if (hitInfo.collider.CompareTag("Teddy"))
                    {
                        hitInfo.collider.GetComponent<Key>().OpenWinDoor();
                    }
                }
            }
        }
	}
}
