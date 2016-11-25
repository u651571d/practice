using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpspeed = 8.0F;
    public float gravity = 20.0F;
    public float rotatespeed = 10F;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.Move(new Vector3(0, -20, 0));
    }

    void Update()
    {
        NomalControl();
        CameraAxisControl();
        jumpControl();
        attachMove();
        attachRotation();
    }



    void NomalControl()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vartical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

        }

       

    }
    void CameraAxisControl()
    {
        if (controller.isGrounded)
        {
            Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
            Vector3 right = Camera.main.transform.TransformDirection(Vector3.right);


            moveDirection = Input.GetAxis("Horizontal") * right + Input.GetAxis("Vartical") * forward;
            moveDirection *= speed;
        }
    }
    void jumpControl()
    {
            if (Input.GetButton("jump"))
                moveDirection.y = jumpspeed;
    }

    void attachMove()
    {
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


    void attachRotation()
    {
        var moveDirectionYzero = -moveDirection;
        moveDirectionYzero.y = 0;
        if (moveDirectionYzero.sqrMagnitude > 0.01)
        {
            float step = rotatespeed * Time.deltaTime;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, moveDirectionYzero, step, 0f);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
    }


}