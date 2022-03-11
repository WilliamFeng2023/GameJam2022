using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toKey : MonoBehaviour
{
    public Collectible key;
    public GameObject keyItem;
    //public Collectible trophie;
    public GameObject AliveTwin;
    public GameObject GhostTwin;

    // Start is called before the first frame update
    void Start()
    {
        keyItem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6 && key.hasItem == true|| collision.gameObject.layer == 12 && key.hasItem == true)
        {
            Destroy(gameObject);
            keyItem.SetActive(true);
        }
    }

}
