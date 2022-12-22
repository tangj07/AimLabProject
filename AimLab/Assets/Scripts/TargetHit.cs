using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public Target target;
    [SerializeField]
    GameObject crosshair;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        target = FindObjectOfType<Target>();
    }
}
