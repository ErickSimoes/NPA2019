using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RemoveMenuScene : MonoBehaviour {
    void Start() {
        SceneManager.UnloadSceneAsync("MenuScene");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("MenuScene");
        }
    }

}
