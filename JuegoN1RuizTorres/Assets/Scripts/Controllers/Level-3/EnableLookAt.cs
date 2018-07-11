using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using UnityEngine;

public class EnableLookAt : MonoBehaviour {

    [SerializeField] GameObject player;
    [SerializeField] AudioSource bm5;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject text1;

    [SerializeField] GameObject playerLook;
    [SerializeField] GameObject playerMove;
   // [SerializeField] GameObject playerNavMesh;
    //[SerializeField] NavMeshAgent pnm;
    [SerializeField] GameObject playerHB;
    [SerializeField] AudioSource walk;

    public float movementSpeed = 10.0f;

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<LookAtController>().enabled = true;

        bm5.Play();

        playerLook.GetComponent<PlayerLook>().enabled = false;
        playerMove.GetComponent<PlayerMove>().walkSpeed = 0f;
       //playerNavMesh.GetComponent<NavMeshAgent>().enabled = true;
        playerHB.GetComponent<HeadBob>().enabled = false;

        walk.enabled = false;

        StartCoroutine(ChangeToText());
        StartCoroutine(ChangeToCanvas());
    }

    IEnumerator ChangeToText()
    {
        yield return new WaitForSeconds(30f);

        text1.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    IEnumerator ChangeToCanvas()
    {
        yield return new WaitForSeconds(79.6f);

        canvas.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        StartCoroutine(EndGame());
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(23f);

        SceneManager.LoadScene("Start");
    }
}
