// Made by Dane
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chandelier : MonoBehaviour
{
    public GameObject item;
    public GameObject Audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //if collider with tag is detected, destroy the object and spawn in the key
    //Majority of code credit: https://answers.unity.com/questions/1524990/how-to-make-an-instance-of-an-object-disappear-whe.html
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Chandelier Collide")
        {
            GameObject Temp = Instantiate(Audio);
            item.SetActive(true);
            Vector3 offset = new Vector3(0.0f, 0.5f, 0.0f);
            Vector3 chandelierPos = gameObject.transform.position + offset;
            item.transform.position = chandelierPos;
            gameObject.SetActive(false);
            //Destroy(gameObject);
            Destroy(Temp, 5);
            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
