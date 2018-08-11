using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
FristPersonMovement
this script is to control the camera movement in the scene

Author: Wenrui Li (u6361099)
     */

public class FristPersonMovement : MonoBehaviour {


    public GameObject camera;
    CharacterController controller;

    public bool isFlyingMode = false;

    public float walkingSpeed = 10f;
    public float flyingSpeed = 20f;
    public float mouseSensitivity = 2f;

    private float clamp = 0.0f;

    public void Start()
    {
        controller = this.GetComponent<CharacterController>();    
    }


    private void Awake()
    {
        //remove the cursor display.
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update () {
        RotateCamera();
        Movement();
        InputListener();

    }


    void InputListener() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("flying mode");
            isFlyingMode = !isFlyingMode;
        } 
    }

    void Movement() {
        if (isFlyingMode)
        {
            //avoid walk over the scene
            if (transform.position.y < 0) {
                Vector3 moveForward = new Vector3(transform.position.x, 0, transform.position.z);
                this.transform.position = moveForward;
            }

            //do flying mode
            this.GetComponent<CapsuleCollider>().enabled = false;

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
                Vector3 moveForward = new Vector3(0,0,Time.deltaTime * flyingSpeed);
                this.transform.Translate(moveForward);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                Vector3 moveForward = new Vector3(0, 0 - Time.deltaTime * flyingSpeed);
                this.transform.Translate(moveForward);

            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                Vector3 moveForward = new Vector3( Time.deltaTime * flyingSpeed, 0, 0);
                this.transform.Translate(moveForward);

            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                Vector3 moveForward = new Vector3(-Time.deltaTime * flyingSpeed, 0, 0);
                this.transform.Translate(moveForward);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                Vector3 moveForward = new Vector3( 0,Time.deltaTime * flyingSpeed, 0);
                this.transform.Translate(moveForward);
            }
            if (Input.GetKey(KeyCode.E))
            {
                Vector3 moveForward = new Vector3(0, -Time.deltaTime * flyingSpeed, 0);
                this.transform.Translate(moveForward);

            }


        }
        else {
            this.GetComponent<CapsuleCollider>().enabled = true;

            //walking
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 moveSide = transform.right * horizontal * walkingSpeed;
            Vector3 moveForward = transform.forward * vertical * walkingSpeed;

            controller.SimpleMove(moveSide);
            controller.SimpleMove(moveForward);
        }
    }


    //for camera rotation
    void RotateCamera() {

        //it is necessary to use eular angles to control the camera rotation
        Vector3 camRot = camera.transform.rotation.eulerAngles;
        
        Vector3 chaRot = this.transform.rotation.eulerAngles;
        //get rotation value from two axises.
        float rotMouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float rotMouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        //transfer the value to the eularangle.
        clamp -= rotMouseY;
        camRot.x -= rotMouseY;
        chaRot.y += rotMouseX;
        //deal with rotation limit angle, they use different angle system.
        //camRot.x = Mathf.Clamp(camRot.x,-90,90);

        if (camRot.x > 90 && camRot.x <180)
        {       
            camRot.x = 90;
        }
        else if (clamp < -90 && camRot.x >180)
        {
            camRot.x = 270;
        }

        //ensure z is not changed
        camRot.z = 0;
        //transer the angle to the camera
        camera.transform.rotation = Quaternion.Euler(camRot);
        this.transform.rotation = Quaternion.Euler(chaRot);
        //print(clamp+","+camRot.x);
     
    }
}
