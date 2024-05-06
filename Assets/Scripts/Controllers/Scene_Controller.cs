using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1.0f;
    }

    public void NextScene()
    {
        ChangeScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousScene()
    {
        ChangeScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void RechargeScene()
    {
        ChangeScene(SceneManager.GetActiveScene().buildIndex);
    }
}
