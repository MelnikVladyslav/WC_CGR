using GameLogic.Initilization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartIn : MonoBehaviour
{
    StartInit startInit = new StartInit();

    // Start is called before the first frame update
    void Start()
    {
        startInit.Start();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
