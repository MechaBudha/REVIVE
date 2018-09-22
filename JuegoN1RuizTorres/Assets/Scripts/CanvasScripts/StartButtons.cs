using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartButtons : MonoBehaviour {

    [SerializeField] private bool quit = false;
    [SerializeField] string nextScene;
   
    public void Awake()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(LoadGame);
        btn.onClick.AddListener(GameExit);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(nextScene);
    }
}
