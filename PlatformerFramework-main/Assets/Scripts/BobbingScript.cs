/*****************************************
 * Edited by: William Feng
 * Implemented: 3/3/2022
 * Description: Up and Down Movement
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingScript : MonoBehaviour
{
    [SerializeField]
    float height = 0.5f;
    [SerializeField]
    float speed = 5f;
    // Start is called before the first frame update
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
