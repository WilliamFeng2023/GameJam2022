/*****************************************
 * Made by: Ryan Scheppler
 * Edited by: William Feng
 * Last Edited: 3/10/21
 * Description: Just changed the LevelToLoad
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDoor : MonoBehaviour
{
    public string LevelToLoad = "VictoryScene";
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
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
