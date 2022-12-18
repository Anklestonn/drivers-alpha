using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;

    [SerializeField] private bool paused;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            showMenu();
        }

        else
        {
            noShowMenu();
        }
    }

    void showMenu()
    {
        pauseUI.SetActive(true);
    }

    void noShowMenu()
    {
        pauseUI.SetActive(false);
    }
}
