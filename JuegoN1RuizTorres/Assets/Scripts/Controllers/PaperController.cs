using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PaperController : MonoBehaviour
{
    public Image noteImage;
    public GameObject hideNoteButton;

    public AudioClip pickupSound;
    public AudioClip putAwaySound;

    public GameObject playerObject;
    public GameObject triggerObject;

    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
    }

    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickupSound);

        hideNoteButton.SetActive(true);

        playerObject.GetComponent<FirstPersonController>().enabled = false;     //Desactiva el controlador del jugador asi no te podes mover mientras ves la nota

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        hideNoteButton.SetActive(false);

        playerObject.GetComponent<FirstPersonController>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        triggerObject.GetComponent<LightsController>().enabled = true;
    }
}