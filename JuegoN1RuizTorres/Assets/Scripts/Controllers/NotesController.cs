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

    private GameObject player;
    private Camera cameraObject;
    [SerializeField] private GameObject pauseCanvas;

    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
        player = FindObjectOfType<GameManager>().GetPlayer();
        cameraObject = FindObjectOfType<GameManager>().GetPlayer().GetComponentInChildren<Camera>();
    }

    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickupSound);

        hideNoteButton.SetActive(true);

        player.GetComponent<PlayerMove>().enabled = false;
        cameraObject.GetComponent<PlayerLook>().enabled = false;
        pauseCanvas.GetComponent<PauseMenu>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        hideNoteButton.SetActive(false);

        player.GetComponent<PlayerMove>().enabled = true;
        cameraObject.GetComponent<PlayerLook>().enabled = true;
        pauseCanvas.GetComponent<PauseMenu>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
