using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FixedButom : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        img = GetComponent<Image>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        img.color = Color.grey;
        Pressed = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        img.color = Color.white;
        Pressed = false;
    }

}
