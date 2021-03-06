/*****************************************
 * Edited by: Ryan Scheppler
 * Edited by William Feng.
 * Last Edited: 1/27/2021
 * Description: Add this to objects thaht are picked up by the player for points and removed
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool pickedUpAlive = false;
    public bool pickedUpGhost = false;
    public bool hasItem = false;

    public int points = 10;
    public int x = 7;

    public AudioClip PickUpNoise;

    public GameObject SpawnOnPickUp;

    public GameObject AliveTwin;
    public GameObject GhostTwin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pickedUpAlive == true)
        {
            float AliveXPos = AliveTwin.transform.position.x;
            float AliveYPos = AliveTwin.transform.position.y;
            Vector3 offset = new Vector3(0.0f, 0.9f, 0.0f);
            transform.position = AliveTwin.transform.position + offset;
            //print(AliveTwin.transform.position.ToString() + transform.position.ToString());
            print(AliveYPos.ToString());
        }
        if (pickedUpGhost == true)
        {
            float GhostXPos = GhostTwin.transform.position.x;
            float GhostYPos = GhostTwin.transform.position.y;
            Vector3 offset = new Vector3(0.0f, 0.9f, 0.0f);
            transform.position = GhostTwin.transform.position + offset;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource PAud = collision.gameObject.GetComponent<AudioSource>();
        if (PAud != null)
        {
            PAud.PlayOneShot(PickUpNoise);
        }
        if (SpawnOnPickUp != null)
        {
            Instantiate(SpawnOnPickUp, transform.position, transform.rotation);
        }
        if (collision.gameObject.CompareTag("Player"))
        { 
            pickedUpAlive = true;
            hasItem = true;
            print(hasItem);
        }
        else if(collision.gameObject.CompareTag("Player2"))
        {
            pickedUpGhost = true;
            hasItem = true;
            print(hasItem);
        }
    }
}
