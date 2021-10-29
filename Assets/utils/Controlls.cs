using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public PlayerMovement plm;
    public Animator WeaponAnimator, animatorPlayer;
    public WeapomTolls wT;
    public Transform initial;
    public LayerMask layerMask;
    public SpriteRenderer mira;
    public FixedButom fb;
    void Start()
    {
        plm = GetComponent<PlayerMovement>();
        animatorPlayer = GetComponent<Animator>();
        wT = FindObjectOfType<WeapomTolls>();
        fb = FindObjectOfType<FixedButom>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit2;
        if (Physics.Raycast(initial.position, initial.forward, out hit2, Mathf.Infinity, layerMask))
        {
            
            if (hit2.collider.gameObject.layer == 10)
            {
                mira.color = Color.red;
            }
            else
            {
                mira.color = Color.green;
            }
        }
            if (plm.move.magnitude > 0.3f)
        {
            animatorPlayer.SetFloat("magnitude", plm.move.magnitude);
        }
        else
        {
            animatorPlayer.SetFloat("magnitude", 0f);
        }
        
        WeaponAnimator.SetFloat("magnitude", plm.move.magnitude);
        shoot();
        /*if (Input.GetMouseButton(0) && wT.canFire)
        {
            wT.canFire = false;
            WeaponAnimator.SetTrigger("fire");

            RaycastHit hit;
            if (Physics.Raycast(initial.position, initial.forward, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log(hit.collider.gameObject.layer);
                if (hit.collider.gameObject.layer == 10)
                {
                    SoundManager.inst.playBulletImpact();
                    hit.collider.gameObject.GetComponent<Damage>().ChangeDamage();
                    // Debug.DrawRay(initial.position, initial.forward * hit.distance, Color.red);
                }
                //else
                //{
                  //  Debug.DrawRay(initial.position, initial.forward * hit.distance, Color.yellow);
                //}
                
            }

        }*/
    }

    public void shoot()
    {
        if (fb.Pressed && wT.canFire)
        {
            wT.canFire = false;
            WeaponAnimator.SetTrigger("fire");

            RaycastHit hit;
            if (Physics.Raycast(initial.position, initial.forward, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log(hit.collider.gameObject.layer);
                if (hit.collider.gameObject.layer == 10)
                {
                    SoundManager.inst.playBulletImpact();
                    hit.collider.gameObject.GetComponent<Damage>().ChangeDamage();
                    // Debug.DrawRay(initial.position, initial.forward * hit.distance, Color.red);
                }
                //else
                //{
                //  Debug.DrawRay(initial.position, initial.forward * hit.distance, Color.yellow);
                //}

            }

        }

    }
    public void PlayLeft()
    {
        SoundManager.inst.playLeft();
    }
    public void PlayRight()
    {
        SoundManager.inst.playRight();
    }
}
