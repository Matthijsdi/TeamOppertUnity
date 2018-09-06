using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBalie : MonoBehaviour {

    public GameObject InfoBalieUI;
    public GameObject HelloText;
    public GameObject AnswerText;
    public GameObject GetCoffeeInfoButton;
    public GameObject NoButton;
    public GameObject ThankYouButton;

    //Trigger
    private void OnTriggerEnter(Collider other)
    {

        InfoBalieUI.SetActive(true);
        Cursor.visible = true;
    }

    private void OnTriggerExit(Collider other)
    {

        InfoBalieUI.SetActive(false);
        Cursor.visible = false;
    }

    //Button Options

    
    public void GetCoffeeInfo()
    {
        Cursor.visible = true;
        //false
        HelloText.SetActive(false);
        GetCoffeeInfoButton.SetActive(false);
        NoButton.SetActive(false);

        //true
        AnswerText.SetActive(true);
        ThankYouButton.SetActive(true);
    }

    public void no()
    {
        InfoBalieUI.SetActive(false);
        Cursor.visible = false;
    }

}
