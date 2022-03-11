/*****************************************
 * Made by: Ryan Scheppler
 * Edited by: William Feng
 * Last Edited: 3/10/21
 * Description: Edited OnTriggerEnter2D and OnTriggerExit2D
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignReading : MonoBehaviour
{
    public GameObject Text;
    public GameObject Text2;
    public Collectible key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Added more conditions for different text to be read
        if(collision.gameObject.CompareTag("Player") && key.hasItem == false)
        {
            Text.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Player") && key.hasItem == true)
        {
            Text2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Set Text2 to false visibility once the players are no longer in collision
        if (collision.gameObject.CompareTag("Player"))
        {
            Text.SetActive(false);
            Text2.SetActive(false);
        }

    }
}
