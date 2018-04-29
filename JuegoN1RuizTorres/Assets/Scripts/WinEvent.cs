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

            Debug.Log("Hello");
            if (ScoreManager.Instance.Score >= 100)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
