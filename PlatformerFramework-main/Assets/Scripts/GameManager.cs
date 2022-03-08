/*****************************************
 * Edited by: Ryan Scheppler
 * Last Edited: 1/27/2021
 * Description: Should be on it's own game object likely alone, only one will exist at a time, handles variables and events more global affecting
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public GameObject aliveTwin;
    public GameObject ghostTwin;

    //allow this component to be grabbed from anywhere and make sure only one exists
    public static GameManager Instance;

    //event to listen to for the score change
    public static UnityEvent ScoreUpdate = new UnityEvent();

    //score property and int behind it
    private static int score_ = (int)PlayerController.health;
    public static int score
    {
        get
        {
            return score_;
        }
        set
        {
            score_ = value;
            ScoreUpdate.Invoke();
        }
    }

    // Health for ghost twin by William Feng
    public static UnityEvent GhostUpdate = new UnityEvent();
    private static int ghostHealth_ = (int)GhostController.health;
    public static int ghostHealth
    {
        get
        {
            return ghostHealth_;
        }
        set
        {
            ghostHealth_ = value;
            GhostUpdate.Invoke();
        }
    }

    //when made make sure this is the only manager, and make the manager persistant through levels
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public static void ResetGame()
    {
        //PlayerController.health = PlayerController.MAXHEALTH;
        //score = (int)PlayerController.MAXHEALTH;
    }

}
