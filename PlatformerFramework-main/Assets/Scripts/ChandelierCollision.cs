// Made by Dane
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChandelierCollision : MonoBehaviour
{
    public GameObject Audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //if collider with tag is detected, destroy the object and spawn in the key
    //Majority of code credit: https://answers.unity.com/questions/1524990/how-to-make-an-instance-of-an-object-disappear-whe.html
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject Temp = Instantiate(Audio);
            Destroy(gameObject);
            Destroy(Temp, 5);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
