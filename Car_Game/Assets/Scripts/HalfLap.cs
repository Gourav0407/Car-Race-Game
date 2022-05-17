using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLap : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject FinishLine;
    void OnTriggerEnter()  
    {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false); 
        FinishLine.SetActive(true);
    }
}
