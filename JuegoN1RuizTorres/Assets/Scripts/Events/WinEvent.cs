using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinEvent : MonoBehaviour {

    [SerializeField] string nextScene;

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {
            if (ScoreManager.Instance.Score >= 200)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
