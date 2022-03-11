// Edited by William Feng
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //Sound Stuff
    AudioSource SFXPlayer;
    public AudioClip openDoor;

    // By William Feng
    public GameObject blocker;
    public bool canBreak = false;
    public GameObject text;
    public Collectible key;
    public GameObject keyItem;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // By William Feng, conditions to delete the door if met
        print("collided");
        if (collision.gameObject.tag == "Player")
        {
            if (key.hasItem == true)
            {
                Destroy(blocker);
                Destroy(gameObject);
                Destroy(key);
                Destroy(keyItem);
                SFXPlayer.PlayOneShot(openDoor);
            }
            else
            {
                print("False");
                text.SetActive(true);
            }
        }
        text.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        text.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
