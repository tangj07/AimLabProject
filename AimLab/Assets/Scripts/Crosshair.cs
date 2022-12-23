using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public bool hit = false;
    public StarterAssetsInputs reference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("target") == true)
        {
            if (reference.shoot == true)
            {
                hit = true;
            }
        }
        else { hit= false; }
    }
}
