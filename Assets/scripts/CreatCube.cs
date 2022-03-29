using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatCube 
{
    /*
    public GameObject mySphere;
    Vector3 a = new Vector3(0, 5, 0); //实例化预制体的position，可自定义
    Quaternion b = new Quaternion(0, 0.707f, 0, 0.707f);//实例化预制体的rotation，可自定义
                                                        // Use this for initialization
                                                      
                                                        // float num = 0.01f;
    Vector3 moveForward = Vector3.zero;
    float moveSpeed = 0.5f;
    */

    public static GameObject creatcube(GameObject cube)
    {
        Vector3 a = new Vector3(0, 7, 0); //实例化预制体的position，可自定义
        Quaternion b = new Quaternion(0, 0.707f, 0, 0.707f);//实例化预制体的rotation，可自定义
        GameObject  CUBE= GameObject.Instantiate(cube, a, b) as GameObject;
        return CUBE;

    }
    /*
    void Start()
    {
        GameObject Sphere = GameObject.Instantiate(mySphere, a, b) as GameObject;
        Invoke(nameof(MethodName), 5);




        Sphere.GetComponent<Rigidbody>().MovePosition(Quaternion.LookRotation(transform.forward) * moveForward * moveSpeed * Time.fixedDeltaTime + transform.position);







    }

    private void MethodName()
    {
        GameObject Sphere2 = GameObject.Instantiate(mySphere, a, b) as GameObject;
        //这里写上duration秒后要执行的内容
    }

    // Update is called once per frame
    void Update()
    {
        
        var v = Sphere.transform.localPosition;
        if (v.y>-5.5)
        {
            v.y = v.y - num;
            Sphere.transform.localPosition = v;
        }
        
        
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveForward.z += -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveForward.x += -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveForward.x += 1;
        }

        */
        
    }





