using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PaperController : MonoBehaviour
{
    [SerializeField] private Image noteImage;
    [SerializeField] private GameObject hideNoteButton;

    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private AudioClip putAwaySound;

    [SerializeField] private GameObject playerObject;
    //[SerializeField] private GameObject triggerObject;
    [SerializeField] private GameObject firstEnemyObject;                          //cuando esta activo prende el script de trigger 


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

        //playerObject.GetComponent<FirstPersonController>().enabled = false;     //Desactiva el controlador del jugador asi no te podes mover mientras ves la nota
        playerObject.GetComponent<PlayerLook>().enabled = false;
        playerObject.GetComponent<PlayerMove>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        hideNoteButton.SetActive(false);

        //playerObject.GetComponent<FirstPersonController>().enabled = true;
        playerObject.GetComponent<PlayerLook>().enabled = true;
        playerObject.GetComponent<PlayerMove>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //triggerObject.GetComponent<LightsController>().enabled = true;
        firstEnemyObject.GetComponent<JumpScareController>().enabled = true;
    }
}