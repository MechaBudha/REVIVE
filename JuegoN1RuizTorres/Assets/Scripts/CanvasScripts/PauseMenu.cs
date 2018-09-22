using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPause = false;
    [SerializeField] UnityEvent onPause;
    [SerializeField] UnityEvent onResume;

    [SerializeField] private GameObject pauseMenuUI;

    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
                Resume();
            else
                Pause();
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;

        OnResume.Invoke();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;

        OnPause.Invoke();
   
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        StartCoroutine(ChangeLevel());
    }

    public UnityEvent OnPause
    {
        get { return onPause; }
    }

    public UnityEvent OnResume
    {
        get { return onResume; }
    }

    IEnumerator ChangeLevel()
    {
        float fadeTime = GameObject.Find("Fade").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Start");
    }
}
