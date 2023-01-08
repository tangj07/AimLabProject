using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public GameObject prefab;
    public GameObject target;
    [SerializeField]
    Crosshair reference;
    public bool hit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeSpawn());
    }
    IEnumerator TimeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            if (hit == true)
            {
                Destroy(target);
                reference.collide = false;
                Vector3 pos = new Vector3(UnityEngine.Random.Range(-5.5f, 12.8f), UnityEngine.Random.Range(1.54f, 7.88f), 24);
                GameObject temp;
                temp = Instantiate(prefab, pos, Quaternion.identity);
                temp.name = "Target";
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        target= GameObject.Find("Target");
        hit = reference.hit;
    }
}
