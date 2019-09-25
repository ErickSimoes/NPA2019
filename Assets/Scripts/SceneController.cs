using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    public Image loadImage;
    public void CallScene(string sceneName) {
        loadImage.gameObject.SetActive(true);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

}
