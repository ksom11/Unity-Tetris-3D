using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLogic5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) //������ײ��Χ
    {
        //Debug.Log("hit");
        GamingData.T5Line++;
        //Debug.Log(GamingData.T5Line);
    }
    void OnTriggerExit(Collider other) //������ײ��Χ
    {
        //Debug.Log("hit");
        GamingData.T5Line--;

    }
}
