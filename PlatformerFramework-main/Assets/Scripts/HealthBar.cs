/*****************************************
 * Edited by: Ryan Scheppler
 * Last Edited: 1/27/2021
 * Description: Add to the TMP Pro text object to keep score updated.
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        /**
        myText = GetComponent<TMP_Text>();
        ChangeText();
        GameManager.HealthUpdate.AddListener(ChangeText);
    **/
    }

    private void ChangeText()
    {
        //myText.text = GameManager.health;

    }
    // Update is called once per frame
    void Update()
    {
        ChangeText();
    }
}
