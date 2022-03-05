using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackgroundMusic : MonoBehaviour
{
    public Camera Camera;
    //Sound Stuff
    AudioSource SFXPlayer;
    public AudioClip Sound;


    void Start()
    {
        SFXPlayer = GetComponent<AudioSource>();
        Camera = Camera.main;
        SFXPlayer = Camera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXPlayer.PlayOneShot(Sound);
        }
    }

}
