using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class NotesController : MonoBehaviour
{
    [SerializeField] private Image noteImage;
    [SerializeField] private GameObject hideNoteButton;

    [SerializeField] private AudioClip pickupSound;
    [SerializeField] private AudioClip putAwaySound;

    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private GameObject weaponObject;
    [SerializeField] private GameObject pauseCanvas;

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

        playerObject.GetComponent<PlayerMove>().enabled = false;
        cameraObject.GetComponent<PlayerLook>().enabled = false;
        weaponObject.GetComponent<Weapon>().enabled = false;
        pauseCanvas.GetComponent<PauseMenu>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        hideNoteButton.SetActive(false);

        playerObject.GetComponent<PlayerMove>().enabled = true;
        cameraObject.GetComponent<PlayerLook>().enabled = true;
        weaponObject.GetComponent<Weapon>().enabled = true;
        pauseCanvas.GetComponent<PauseMenu>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
