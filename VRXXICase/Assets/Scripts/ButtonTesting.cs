using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTesting : MonoBehaviour
{
    private int currentIndex;

    private void Update()
    {
        currentIndex = GetComponent<TimelineManager>().currentIndex;
        Debug.Log("Now we are at" + currentIndex);
    }
    public void SelectIndex(int indexTimeline)
    {
        TimelineManager timelineManager = GetComponent<TimelineManager>();
        timelineManager.currentIndex = indexTimeline;
        //GetComponent<TimelineManager>().PlayFromTimelines(indexTimeline);
        timelineManager.PlayTimelineObject(indexTimeline);
        timelineManager.StopTimelineObject(currentIndex);
    }
}
