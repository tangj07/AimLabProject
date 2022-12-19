using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position.x = gameObject.transform.position.x;
        position.y = gameObject.transform.position.y;
        position.z = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
