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

				if(InputManager.Instance.GetAction())
                {
                    if(hitInfo.collider.CompareTag("Note"))
                    {
                        hitInfo.collider.GetComponent<NotesController>().ShowNoteImage();
                    }

                    if (hitInfo.collider.CompareTag("Key1"))
                    {
                        hitInfo.collider.GetComponent<KeyController>().PickUp();
                    }

                    if (hitInfo.collider.CompareTag("Button"))
                    {
                        hitInfo.collider.GetComponent<ButtonController>().FirstButton();
                    }

                    if (hitInfo.collider.CompareTag("Button2"))
                    {
                        hitInfo.collider.GetComponent<ButtonController>().SecondButton();
                    }

                    if (hitInfo.collider.CompareTag("Door"))
                    {
                        hitInfo.collider.GetComponent<DoorLocked>().TryToOpen();
                    }

                    if (hitInfo.collider.CompareTag("Teddy"))
                    {
                        hitInfo.collider.GetComponent<BearController>().PickUp();
                    }

                    if (hitInfo.collider.CompareTag("ButtonMaze"))
                    {
                        hitInfo.collider.GetComponent<DoorMazeController>().OpenDoor();
                    }

                    if (hitInfo.collider.CompareTag("Open"))
                    {
                        hitInfo.collider.GetComponent<OpenDoorController>().OpenDoor();
                    }

                    if (hitInfo.collider.CompareTag("Wall"))
                    {
                        hitInfo.collider.GetComponent<WallController>().OpenWall();
                    }

                    if (hitInfo.collider.CompareTag("Key"))
                    {
                        hitInfo.collider.GetComponent<KeysController>().PickUp();
                    }
                }
            }
        }
	}
}
