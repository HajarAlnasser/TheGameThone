using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseGameController : MonoBehaviour
{

    [SerializeField] private GameObject pause;
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

    private void pauseGame(InputAction.CallbackContext obj)
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

    // Start is called before the first frame update
   
}
