using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject Scene;
    public void SceneChanage()
    {
        SceneManager.LoadScene("Menu");
    }
}
