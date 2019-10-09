using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    public Animator fade;
    public string sceneInput;
    public void CallScene(string sceneName) 
    {
        sceneInput = sceneName;
        StartCoroutine(CallingDelay(sceneInput));
    }

    IEnumerator CallingDelay(string sceneName)
    {
        fade.SetTrigger("fadeIn");
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(sceneName);
    }

}
