using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
   public float mouseSensetevety = 100f;
    public Transform camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X")*mouseSensetevety * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mouseSensetevety * Time.deltaTime;
        camera.Rotate(Vector3.up, mousex);
    }
}
