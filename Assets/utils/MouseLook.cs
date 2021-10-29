using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    public float mouseSen,rotationX = 0f;
    public Transform playerBody;
    public FixedTouchField ftf;
    public MenuProp menuProp;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        menuProp = FindObjectOfType<MenuProp>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = ftf.TouchDist.x * mouseSen* menuProp.value * Time.deltaTime;
        float inputY = ftf.TouchDist.y * mouseSen* menuProp.value * Time.deltaTime;
        rotationX -= inputY;
        rotationX = Mathf.Clamp(rotationX, -28f, 58f);
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        playerBody.Rotate(Vector3.up * inputX);
    }
}
