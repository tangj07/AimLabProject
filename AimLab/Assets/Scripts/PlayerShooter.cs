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
    public bool hit;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RotCamera();
    }

    private void RotCamera()
    {
        Vector2 inputVals = new Vector2();
    }
}
