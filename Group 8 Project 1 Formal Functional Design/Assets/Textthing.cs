using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textthing : MonoBehaviour
{
    public static List<int> buttonIDs;
    public GameObject useText;
    void Start()
    {
        buttonIDs = new List<int>();
    }

    void Update()
    {
        if (buttonIDs.Count > 0)
        {
            useText.SetActive(true);
        } else
        {
            useText.SetActive(false);
        }
    }
}
