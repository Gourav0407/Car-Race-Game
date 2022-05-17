using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float milliSecCount;
    public static string milliDisplay;

    public GameObject minBox;
    public GameObject secBox;
    public GameObject milliSecBox;
    void Update()
    {
        milliSecCount += Time.deltaTime * 10;
        milliDisplay = milliSecCount.ToString("f0");
        milliSecBox.GetComponent<Text>().text = "" + milliDisplay;

        if (milliSecCount >= 10)
        {
            milliSecCount = 0;
            secCount += 1;
        }
        if (secCount <= 9)
        {
            secBox.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            secBox.GetComponent<Text>().text = "" + secCount + ".";
        }

        if (secCount >= 60)
        {
            secCount = 0;   
            minCount += 1;
        }
        if (secCount <= 9)
        {
            minBox.GetComponent<Text>().text = "0" + minCount + ":";
        }
        else
        {
            minBox.GetComponent<Text>().text = "" + minCount + ":";
        }

    }
}
