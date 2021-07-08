using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine.Video;

public class SignalFor : MonoBehaviour
{
    //Signal for the time on Timeline jump to a certain second
    public void TimeJumpTo(float time)
    {
        PlayableDirector thisPlayableDir = GetComponent<PlayableDirector>();
        thisPlayableDir.time = time;
    }

    //Signal for stop current Timeline then play next Timeline
    public void PlayTimeline(PlayableDirector timeline)
    {
        GetComponent<PlayableDirector>().Stop();
        gameObject.SetActive(false);
        timeline.Play();
    }
}
