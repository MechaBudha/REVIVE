using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SceneEnum {
    Start = 0,
    LoadingL1,
    Level1,
    Level2,
    level3,
    TotalScenes
};

public class SceneLoadManager : MonoBehaviour {

    private static SceneLoadManager instance = null;

    public static SceneLoadManager Instance {
        get {
            instance = FindObjectOfType<SceneLoadManager>();
            if (instance == null) {
                GameObject go = new GameObject("Scene Load Manager");
                instance = go.AddComponent<SceneLoadManager>();
            }
            return instance;
        }
    }

    SceneEnum currentScene;

	void Awake () {
        DontDestroyOnLoad(gameObject);
        Debug.Log("slmAwake");
        currentScene = 0;
    }

    public void Initialize() {
       
        Debug.Log("hola");
    }

    public string GetNextScene() {
        currentScene++;
        Debug.Log(currentScene);
        return currentScene.ToString();
    }
}
