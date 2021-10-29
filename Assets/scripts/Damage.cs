using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject lifeView;
    int life = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeDamage()
    {
        life -= Random.Range(5, 30);
        lifeView.transform.localScale = new Vector3(life / 100f, lifeView.transform.localScale.y, lifeView.transform.localScale.z);

        if (lifeView.transform.localScale.x <= 0)
        {
            lifeView.transform.localScale = new Vector3(0f, lifeView.transform.localScale.y, lifeView.transform.localScale.z);
            Destroy(this.gameObject);
        }
    }
}
