using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    private int screenshotsTaken;
    void Start()
    {
        if(!PlayerPrefs.HasKey("Screenshots"))
        {
            PlayerPrefs.SetInt("Screenshots", 0);
        }

        screenshotsTaken = PlayerPrefs.GetInt("Screenshots");
    }

    // Update is called once per frame
    public void TakeScreenshot()
    {
        screenshotsTaken = screenshotsTaken = PlayerPrefs.GetInt("Screenshots");
        ScreenCapture.CaptureScreenshot("NPA2019_"+ screenshotsTaken + ".png");
        PlayerPrefs.SetInt("Screenshots", screenshotsTaken + 1);
    }

    
}
