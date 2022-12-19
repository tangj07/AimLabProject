using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Target target;
    public bool hit;
    public PlayerShooter shooter;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        hit = shooter.hit;
<<<<<<< Updated upstream
        target = FindObjectOfType<Target>();
=======
        //target = FindObjectsOfType<Target>();
>>>>>>> Stashed changes
    }
}
