using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toKey : MonoBehaviour
{
    public GameObject key;
    public Collectible trophie;
    public GameObject AliveTwin;
    public GameObject GhostTwin;

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
        if(collision.gameObject.layer == 6 && trophie.hasTrophie == true|| collision.gameObject.layer == 12 && trophie.hasTrophie == true)
        {
            Destroy(gameObject);
            key.SetActive(true);
        }
    }

}
