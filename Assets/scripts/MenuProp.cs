using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuProp : MonoBehaviour
{
    public GameObject menuWindow;
    public float value;
    public Slider slider;
    void Start()
    {
        Time.timeScale = 1;
        menuWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        value = slider.value;
    }

    public void menuPause()
    {
        GetComponent<Button>().interactable = false;
        Time.timeScale = 0;
        menuWindow.SetActive(true);
    }
    public void menuResume()
    {
        GetComponent<Button>().interactable = true;
        Time.timeScale = 1;
        menuWindow.SetActive(false);
    }
    public void reloadScene()
    {
        SceneManager.LoadScene("Game");
    }
}
