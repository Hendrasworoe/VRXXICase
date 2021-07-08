using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeToJump : MonoBehaviour
{
    public void JumpTo (float time)
    {
        PlayableDirector thisPlayableDir = GetComponent<PlayableDirector>();
        thisPlayableDir.time = time;
    }
}
