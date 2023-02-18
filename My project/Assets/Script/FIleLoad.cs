using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FIleLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public Text [] textGUI;
    public string [] path;
 

    // Update is called once per frame
    void Start()
    {
        for(int i = 0; i < path.Length; i++) 
        {
            textGUI[i].text = System.IO.File.ReadAllText(path[i]);
        }
    }
}
