using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public bool collide = false;
    public StarterAssetsInputs reference;
    public bool shoot, hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot = reference.shoot;
        if (collide==true&&shoot == true)
        {
            Debug.Log("hitsadsadsad bitvh");
            hit = true;
        }
        else { hit= false; }
    }
    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "target")
        {
            collide = true;
        }
        else { collide= false; }
    }
}
