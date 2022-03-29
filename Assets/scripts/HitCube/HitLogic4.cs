using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLogic4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) //进入碰撞范围
    {
        //Debug.Log("hit");
        GamingData.T4Line++;
        //Debug.Log(GamingData.T4Line);
    }
    void OnTriggerExit(Collider other) //进入碰撞范围
    {
        //Debug.Log("hit");
        GamingData.T4Line--;

    }
}
