using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{
    public Image imgCircle; //indicator image
    public UnityEvent GVRClick; //event to something clicked by gaze on it
    public float totalTime = 2; //total time to hold gazing
    bool gvrStatus; //button's status gazed or not
    private float gvrTimer; //time button gazed


    // Update is called once per frame
    void Update()
    {
        //increase time gazed & gain amount indicator image
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        //when gazed more than total time, event activated then restart amount & time gazed
        if (gvrTimer > totalTime)
        {
            gvrStatus = false;
            imgCircle.fillAmount = 0;
            gvrTimer = 0;
            GVRClick.Invoke();
        }
    }

    //activate status when button gazed
    public void GvrOn()
    {
        gvrStatus = true;
    }

    //deactivate status when button not gazed then reset amount & time gazed
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }

    public void QuitApp()
    {
        Application.Quit(); //quit application
    }
}
