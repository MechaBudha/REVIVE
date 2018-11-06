using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinEvent : MonoBehaviour {

    [SerializeField] string nextScene;
    [SerializeField] AudioSource _audio;

    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player")) {
            if (ScoreManager.Instance.Score >= 200) {
                _audio.Play();
                StartCoroutine(ChangeLevel());
                //SceneManager.LoadScene(nextScene);
            }
        }
    }

    IEnumerator ChangeLevel() {
        float fadeTime = GameObject.Find("Fade").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(nextScene);
    }
}
