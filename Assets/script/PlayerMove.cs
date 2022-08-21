using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]

public class PlayerMove : MonoBehaviour
{
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    //    public float gravity = 20.0f;


    CharacterController characterController;

    [SerializeField]
    private float speed;
    [SerializeField] private float turnSmoothTime = 0.1f, turnSmoothVelocity;
    [SerializeField] private Transform cam;

    private Vector3 moveDir;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    //[HideInInspector]
    //public bool canMove = true;

    [Header("Gravity")]
    [SerializeField] float gravity = 9.8f;
    [SerializeField] float gravityMultiplier = 2;
    [SerializeField] float groundedGravity = -0.5f;
    [SerializeField] float jumpHeight = 3f;
    [SerializeField] float velocityY = 3f;


    private bool isInteractable;
    private PlayerAction player_Action;
   // private PlayerMove move;
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
        if (!isInteractable) return;
        // 
        throw new NotImplementedException();
    }

    private void OnDisable()
    {
        //player_Action.PlayerControl.Interaction.started -= playerInteract;

        player_Action.PlayerControl.Disable();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("interactable"))
        {
            isInteractable = true;

        }
    }
       private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("interactable"))
        {
            isInteractable = false;

        }
    }

    //// sounds 
    ////[SerializeField] private zizoSounds zS;


    void Start()
    {

      
     
        characterController = GetComponent<CharacterController>();

        // Lock cursor
        //    Cursor.lockState = CursorLockMode.Locked;

    }

    void FixedUpdate()
    {

        float horizonta = player_Action.PlayerControl.Move.ReadValue<Vector2>().x;
            //Input.GetAxisRaw("Horizontal");
        float verical = player_Action.PlayerControl.Move.ReadValue<Vector2>().y;
        //Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizonta, 0f, verical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            //----------------------------------
            // ### move according to camera
            //float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            // ### move according to to world direction
            float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //----------------------------------


            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            moveDir = Quaternion.Euler(0f, TargetAngle, 0f) * Vector3.forward;

            bool isRunning = Input.GetKey(KeyCode.LeftShift);
            speed = (isRunning ? runningSpeed : walkingSpeed);
            characterController.Move(moveDir.normalized * speed * Time.deltaTime);

        }
        if (characterController.isGrounded && velocityY < 0f)
            velocityY = groundedGravity;
        if (characterController.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            velocityY = Mathf.Sqrt(jumpHeight * 2f * gravity);
        }
        velocityY -= gravity * gravityMultiplier * Time.deltaTime;
        characterController.Move(Vector3.up * velocityY * Time.deltaTime);
    }




    

}



