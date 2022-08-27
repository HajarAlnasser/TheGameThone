using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerStandInLine : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject music, sarieee, player, point, newCamera,oldCamera, camClass, pointInClass, textPressAny;
    private bool playerMove=false, changeCam=false;
    private AudioSource aud;
    private int speed = 2;
    private Animator anim;


    private PlayerAction player_Action;


    private void Awake()
    {
        player_Action = new PlayerAction();


    }


    private void OnEnable()
    {

        player_Action.PlayerControl.Enable();
    }

    private void playerInteract(InputAction.CallbackContext obj)
    {
        newCamera.SetActive(false);
        camClass.SetActive(true);

        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = pointInClass.transform.position;
        player.GetComponent<CharacterController>().enabled = true;

        anim.SetBool("isSit", true);
        textPressAny.SetActive(false);

        music.SetActive(true);
        sarieee.SetActive(false);

    }

    private void OnDisable()
    {
        player_Action.PlayerControl.anyButton.started -= playerInteract;

        player_Action.PlayerControl.Disable();

    }

    void Start()
    {
        aud = sarieee.GetComponent<AudioSource>();
        anim = player.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            music.SetActive(false);
            sarieee.SetActive(true);

            player.GetComponent<PlayerMove>().enabled = false;
            playerMove = true;
            changeCam = true;
            anim.SetBool("isWalk", true);
            player_Action.PlayerControl.anyButton.started += playerInteract;
            textPressAny.SetActive(true);



        }
    }

    private void FixedUpdate()
    {
        if (changeCam)
        {
            StartCoroutine(classStu());
            oldCamera.SetActive(false);
            newCamera.SetActive(true);
            changeCam = false;
        }

        if (playerMove)
        {
            var step = speed * Time.deltaTime; // calculate distance to move
            player.transform.position = Vector3.MoveTowards(player.transform.position, point.transform.position, step);
            if (player.transform.position == point.transform.position)
            {
                playerMove = false;
                anim.SetBool("isWalk", false);



            }

        }


      IEnumerator classStu()
        {
            yield return new WaitForSeconds(70);

            jumpToClass();


       }


         void jumpToClass()
        {


            newCamera.SetActive(false);
            camClass.SetActive(true);

            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = pointInClass.transform.position;
            player.transform.localEulerAngles = new Vector3 (0,-90,0);
            player.GetComponent<CharacterController>().enabled = true;

            anim.SetBool("isSit", true);
            textPressAny.SetActive(false);


            music.SetActive(true);
            sarieee.SetActive(false);

        }

    }



}
