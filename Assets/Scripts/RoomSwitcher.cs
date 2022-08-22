using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitcher : MonoBehaviour
{
    [SerializeField] GameObject Camera;
    [SerializeField] Transform MainChar;

    [SerializeField,Space(10)] Transform BedRoomInside;
    [SerializeField] Transform BedRoomOutside;
    [SerializeField] Transform BedRoomCameraPos;


    [SerializeField, Space(10)] Transform HallWayDown;
    [SerializeField] Transform HallWayUpper;
    [SerializeField] Transform HallWayCameraPos;


    [SerializeField, Space(10)] Transform LivingRoomEnter;
    [SerializeField] Transform KitchenEnter;
    [SerializeField, Space(10)] Transform LivingRoomCameraPos;
    [SerializeField] Transform KitchenCameraPos;
 

    CharacterController CharController;

    private void Start()
    {
        CharController = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        //-------------------- Bedroom -----------------------//
        if (collider.gameObject.tag == "Bedroom")
        {
            if (collider.name == "Inside-BedRoom")
            {
                Debug.Log("I'm inside bedroom!");

                CharController.enabled = false;

                this.gameObject.transform.position = BedRoomOutside.position;

                CharController.enabled = true;

                Camera.transform.position = HallWayCameraPos.transform.position;
            }

            if (collider.name == "Outside-BedRoom")
            {
                Debug.Log("I'm inside Hall Way!");

                CharController.enabled = false;

                MainChar.transform.position = BedRoomInside.position;

                CharController.enabled = true;

                Camera.transform.position = BedRoomCameraPos.transform.position;
            }
        }

        //-------------------- Hall Way -----------------------//
        if (collider.gameObject.tag == "HallWay")
        {
            if (collider.name == "Upper-Hall Way")
            {
                Debug.Log("I'm inside Livingroom!");

                CharController.enabled = false;

                this.gameObject.transform.position = HallWayDown.position;

                CharController.enabled = true;

                Camera.transform.position = LivingRoomCameraPos.transform.position;
            }

            if (collider.name == "Down-Hall Way")
            {
                Debug.Log("I'm inside Hall Way!");

                CharController.enabled = false;

                this.gameObject.transform.position = HallWayUpper.position;

                CharController.enabled = true;

                Camera.transform.position = HallWayCameraPos.transform.position;
            }
        }

        //-------------------- Living Room -----------------------//
        if (collider.gameObject.tag == "LivingRoom")
        {
            if (collider.name == "Enter-LivingRoom")
            {
                Camera.transform.position = LivingRoomCameraPos.transform.position;
            }

            if (collider.name == "Enter-Kitchen")
            {
                Camera.transform.position = KitchenCameraPos.transform.position;
            }
        }
    }
}
