/*****************************************
 * Edited by: William feng
 * Last Edited: 2/7/2022
 * Description: Basically a duplicate of Ryan's ScoreText, but meant for the ghost
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GhostHealthText : MonoBehaviour
{
    TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        ChangeText();
        GameManager.GhostUpdate.AddListener(ChangeText);
    }

    public void ChangeText()
    {
        myText.text = "Health: " + GameManager.ghostHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
