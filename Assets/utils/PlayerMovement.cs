using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public Vector3 velocity, move;
    public float gravity = -9.8f;
    public float radius,Hei, runIncrease;
    public Transform pspe;
    public LayerMask lm;
    public bool isground,canJump = false;

    private FloatingJoystick flJ;
    private void Start()
    {
        flJ = GameObject.FindGameObjectWithTag("movement").GetComponent<FloatingJoystick>();
        //flj2 = GameObject.FindGameObjectWithTag("axis").GetComponent<FloatingJoystick>();
    }
    // Update is called once per frame
    void Update()
    {
        
        isground = Physics.CheckSphere(pspe.position, radius, lm);

        if (Input.GetButtonDown("Jump") && isground && canJump)
        {
            velocity.y = Mathf.Sqrt(Hei * -2 * gravity);
        }


        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        

        Vector2 vecMov = new Vector2(X, Z) + flJ.Direction;

        if(isground && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        move = transform.right.normalized * vecMov.x + transform.forward * vecMov.y;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * speed * Time.deltaTime * runIncrease);
        }
        else
        {
            controller.Move(move * speed *Time.deltaTime);
        }
        
        
        velocity.y += gravity * Time.deltaTime;


        controller.Move(velocity * Time.deltaTime);
    }

}
