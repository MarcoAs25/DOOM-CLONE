using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager inst;
    public AudioSource[] footSteps;
    public AudioSource fireWeapom,bulletImpact;
    private void Awake()
    {
        if (inst != null && inst != this)
        {
            Destroy(gameObject);
        }
        else
        {
            inst = this;
        }
    }

    public void playLeft()
    {
        footSteps[0].Play();
    }
    public void playRight()
    {
        footSteps[1].Play();
    }
    public void playFireWeapom()
    {
        fireWeapom.Play();
    }
    public void playBulletImpact()
    {
        bulletImpact.Play();
    }
}
