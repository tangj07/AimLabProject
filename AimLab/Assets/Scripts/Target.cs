using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 position, size;
    [SerializeField] //edit speed in update not here if u want change speed
    float speed = 2f;
    Vector3 targetPos = Vector3.zero;
    Vector3 velocity = Vector3.zero;
    Vector3 direction = Vector3.right;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
        position.x = gameObject.transform.position.x;
        position.y = gameObject.transform.position.y;
        position.z = gameObject.transform.position.z;
        size = GetComponent<Renderer>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {

        speed = 2f;
        
        velocity = direction * speed * Time.deltaTime;

        targetPos += velocity;

        transform.position = targetPos;

        if(transform.position.x > 19f)
        {
            direction *= -1f;
        }
        if (transform.position.x < -11f)
        {
            direction *= -1f;
        }
    }
}
