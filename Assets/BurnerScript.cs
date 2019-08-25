using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerScript : MonoBehaviour
{
    public GameObject burnerFire , smokeFire;
    public GameObject water;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BurnerOn()
    {
        burnerFire.SetActive(true);
    }

    public void BurnerOff()
    {
        smokeFire.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BeakerA" || collision.gameObject.name == "BeakerB" || collision.gameObject.name == "BeakerC")
        {
            water.SetActive(false);
        }
    }
}
