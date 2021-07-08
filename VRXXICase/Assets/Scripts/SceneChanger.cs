using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //Change next scene by [NameScene]
    public void ChangeScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
