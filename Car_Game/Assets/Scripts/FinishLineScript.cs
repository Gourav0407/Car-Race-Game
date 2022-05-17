using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    public GameObject lapCompleteTrig;
    public GameObject halfLapTrig;
    public GameObject Score;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliSecDisplay;
    public GameObject minDisplay2;
    public GameObject secDisplay2;
    public GameObject milliSecDisplay2;

    private double second=999999999;
    


    void OnTriggerEnter()
    {
        if (second > TimeManager.secCount + TimeManager.minCount * 60)
        {
            if (TimeManager.secCount <= 9)
            {
                secDisplay.GetComponent<Text>().text = "0" + TimeManager.secCount + ".";
            }
            else
            {
                secDisplay.GetComponent<Text>().text = "" + TimeManager.secCount + ".";
            }


            if (TimeManager.minCount <= 9)
            {
                minDisplay.GetComponent<Text>().text = "0" + TimeManager.minCount + ".";
            }
            else
            {
                minDisplay.GetComponent<Text>().text = "" + TimeManager.minCount + ".";
            }

            milliSecDisplay.GetComponent<Text>().text = "" + TimeManager.milliSecCount + ".";
            

            second = TimeManager.secCount + TimeManager.minCount * 60;


        }

        if (TimeManager.secCount <= 9)
        {
            secDisplay2.GetComponent<Text>().text = "0" + TimeManager.secCount + ".";
        }
        else
        {
            secDisplay2.GetComponent<Text>().text = "" + TimeManager.secCount + ".";
        }


        if (TimeManager.minCount <= 9)
        {
            minDisplay2.GetComponent<Text>().text = "0" + TimeManager.minCount + ".";
        }
        else
        {
            minDisplay2.GetComponent<Text>().text = "" + TimeManager.minCount + ".";
        }

        milliSecDisplay2.GetComponent<Text>().text = "" + TimeManager.milliSecCount + ".";

        TimeManager.secCount = 0;
        TimeManager.minCount = 0;
        TimeManager.milliSecCount = 0;


        halfLapTrig.SetActive(true);
        lapCompleteTrig.SetActive(false);
        Score.SetActive(true);

    }
}
