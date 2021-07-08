using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRInteractObject : MonoBehaviour
{
    public Image imgCircle; //indicator image
    public UnityEvent GVRClick; //event to something clicked by gaze on it
    public float totalTime = 2; //total time to hold gazing
    bool gvrStatus; //object's status gazed or not
    private float gvrTimer; //time object gazed

    // Update is called once per frame
    void Update()
    {
        //increase time gazed & gain amount indicator image
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        //when gazed more than total time, event activated then restart amount
        //& set object's tag to untagged
        if (gvrTimer > totalTime)
        {
            gvrStatus = false;
            gameObject.tag = "Untagged";
            imgCircle.fillAmount = 0;
            GVRClick.Invoke();
        }
    }

    //activate status when object gazed
    public void GvrOn()
    {
        if(gameObject.tag == "Clickable")
        {
            gvrStatus = true;
        }
    }

    //deactivate status when object not gazed then reset amount & time gazed
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
