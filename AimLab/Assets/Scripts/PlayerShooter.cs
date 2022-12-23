using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCheckForShooting(InputValue value)
    {
        RaycastHit watIHit;
        if (Physics.Raycast(transform.position, transform.forward, out watIHit, Mathf.Infinity))
        {
            Debug.Log(watIHit.collider.name);
        }
    }
}
