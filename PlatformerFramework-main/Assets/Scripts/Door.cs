using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //Sound Stuff
    AudioSource SFXPlayer;
    public AudioClip openDoor;

    public GameObject blocker;
    public bool canBreak = false;
    public GameObject textt;
    public GameObject woodParticle;
    public Collectible trophie; 


    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("collided");
        if (collision.gameObject.tag == "Player")
        {
            //textt.SetActive(true);
            if (trophie.hasTrophie == true)
            {
                Destroy(blocker);
                Destroy(gameObject);
                Destroy(trophie);
            }
            else
            {
                print("False");
                textt.SetActive(true);
            }
        }
        textt.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canBreak = false;
        textt.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && canBreak)
        {
            SFXPlayer.PlayOneShot(openDoor);
            Destroy(blocker);
            Destroy(gameObject);
        }
    }
}
