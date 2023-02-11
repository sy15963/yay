using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    bool [] condition = new bool[3];
    public GameObject[] lightEffect; 

    void Start()
    {
        condition[0] = true;
    }

    
    public void LightSetting(int number)
    {
        condition[number] = !condition[number];

        lightEffect[number].SetActive(condition[number]);
    }
}
