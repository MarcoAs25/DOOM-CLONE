using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapomTolls : MonoBehaviour
{
    public bool canFire = true;
    public Vector3 halfBoxSize;
    public float playerHeightOffset;
    public LayerMask layerMask;
    public void playFire()
    {
        SoundManager.inst.playFireWeapom();
    }
    public void setCanFire(bool cf)
    {
        this.canFire = cf;
    }
    private void Update()
    {

    }
}
