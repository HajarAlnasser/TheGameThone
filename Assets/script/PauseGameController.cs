using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class PauseGameController : MonoBehaviour
{

    [SerializeField] private GameObject pause, pausePanel, optionPanel,musicButton, backToOptionButton;
    private bool isPaused=false;

    private PlayerAction player_Action;
    private void Awake()
    {
        player_Action = new PlayerAction();


    }

    private void OnEnable()
    {
        player_Action.PlayerControl.pause.started += pauseGame;

        player_Action.PlayerControl.Enable();
    }

    private void OnDisable()
    {
        player_Action.PlayerControl.pause.started -= pauseGame;

        player_Action.PlayerControl.Disable();

    }

    public void pauseGame(InputAction.CallbackContext obj)
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            pause.SetActive(false);
            isPaused = false;

        }

    }    public void pauseGame2()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            pause.SetActive(false);
            isPaused = false;

        }

    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void optionPannel()
    {
        pausePanel.SetActive(false);
        optionPanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(musicButton);



    }
    public void backToPausePanel()
    {
        optionPanel.SetActive(false);
        pausePanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backToOptionButton);

    }





    // Start is called before the first frame update

}
