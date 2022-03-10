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
            Destroy(gameObject);
            Destroy(Temp, 5);
            item.SetActive(true);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
