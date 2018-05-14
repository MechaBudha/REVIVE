using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    [SerializeField] private GameObject backgroundMusic;

    void Start()
    {
        backgroundMusic.SetActive(true);
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(65f);
        backgroundMusic.SetActive(false);

        SceneManager.LoadScene("Start");
    }
}
