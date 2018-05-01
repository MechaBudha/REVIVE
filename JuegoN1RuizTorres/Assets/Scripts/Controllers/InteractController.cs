using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractController : MonoBehaviour {

    public string interactButton;

    public float interactDistance = 3f;
    public LayerMask interactLayer;         //Filtro para que no se pueda interactuar con todo

    public Image interactIcon;

    public bool isInteracting;

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
                        hitInfo.collider.GetComponent<PaperController>().ShowNoteImage();

                    }
                }

            }
        }
	}
}
