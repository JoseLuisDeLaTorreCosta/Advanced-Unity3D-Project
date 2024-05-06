using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public GameObject UI;
    public GameObject PauseUI;
    public Time_Controller _time;

    bool paused;

    private void Start()
    {
        paused = false;
    }

    public void Pause()
    {
        if (paused)
        {
            paused = false;
            UI.SetActive(true);
            PauseUI.SetActive(false);
            LockCursor();
            _time.Resume();
        }
        else
        {
            paused = true;
            UI.SetActive(false);
            PauseUI.SetActive(true);
            UnlockCursor();
            _time.Stop();
        }
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
