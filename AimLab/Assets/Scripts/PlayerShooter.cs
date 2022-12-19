using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] 
    private float lookSens;

    [SerializeField]
    private float smoothing;

    private GameObject player;
    public bool hit = false;
    public Target target;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RotCamera();
        target = FindObjectsOfType<Target>();
        //hit = CircleCollision( , target);
    }

    private void RotCamera()
    {
        Vector2 inputVals = new Vector2();
    }
    //private bool CircleCollision( objecta, Target objectb)
    //{
    //    SpriteRenderer spritea = objecta.GetComponent<SpriteRenderer>();
    //    SpriteRenderer spriteb = objectb.GetComponent<SpriteRenderer>();

    //    float distance = Mathf.Pow(spritea.bounds.center.x - spriteb.bounds.center.x, 2)
    //        + Mathf.Pow(spritea.bounds.center.y - spriteb.bounds.center.y, 2);
    //    if (distance <= ((spritea.bounds.max.x - spritea.bounds.center.x) +
    //        (spriteb.bounds.max.x - spriteb.bounds.center.x)) *
    //        ((spritea.bounds.max.x - spritea.bounds.center.x) +
    //        (spriteb.bounds.max.x - spriteb.bounds.center.x)))
    //    {
    //        return true;
    //    }
    //    else { return false; }
    //}
}
