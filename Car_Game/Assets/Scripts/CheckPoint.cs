using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public GameObject FinishLine;
    public GameObject Start;
    public GameObject Score;

    void OnTriggerEnter()
    {
        FinishLine.SetActive(false);
        Start.SetActive(false);
        Score.SetActive(false);

    }
}
