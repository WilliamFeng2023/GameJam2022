/**
 * Bobbing Script
 * Made by Will
 * Started: 3/2/2022
 * Finished: ...
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingScript : MonoBehaviour
{
    public GameObject gameObject;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        gameObject.transform.position = new Vector3(0, y, 0);
    }
}
