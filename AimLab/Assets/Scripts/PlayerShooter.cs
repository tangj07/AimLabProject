using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{

    public bool hit = false;
    public Target target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = FindObjectOfType<Target>();
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
