using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager  : MonoBehaviour, IZUpdate
{
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject OutCube;
    Vector3 moveForward = Vector3.zero;
    float moveSpeed = 1.0f;
    public bool CreatingCube = false;
    public int rand=1;
    void Start()
    {
        AllUpdate.AddUpdate(this);
        OutCube =CreatCube.creatcube(Cube1);
    }

    // Update is called once per frame
    public void ZUpdate()
    {
        if(GamingData.GameOver)
        {
            CreatingCube = true;
            Debug.Log("GameOver");
        }
        rand++;
        if(rand>3)
        {
            rand = 1;
        }
        if (GetSpeed(OutCube)!=0)
        {
            var vv = OutCube.transform.localPosition;
            if (vv.x<3.9& vv.x >-3.9)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    var v = OutCube.transform.localPosition;
                    v.x = v.x - 1f;
                    OutCube.transform.localPosition = v;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    var v = OutCube.transform.localPosition;
                    v.x = v.x + 1f;
                    OutCube.transform.localPosition = v;
                }
            }
            
            //OutCube.GetComponent<Rigidbody>().MovePosition(Quaternion.LookRotation(transform.forward) * moveForward * moveSpeed * Time.fixedDeltaTime + transform.position);
        }
        if (!CreatingCube)
        {
            CreatingCube = true;
            Invoke(nameof(MethodName), 2);
        }

        if (GamingData.FirstLine > 10)
        {
            GamingData.DestroyFLCube = true;
            
        }
        
        if (GamingData.HadDestroyFLCube > 10)
        {
            GamingData.DestroyFLCube = false;
            GamingData.HadDestroyFLCube = 0;
            GamingData.FirstLine = 0;
        }


        if (GamingData.SeconLine > 10)
        {
            GamingData.DestroySLCube = true;
        }
        if (GamingData.HadDestroySLCube > 10)
        {
            GamingData.DestroySLCube = false;
            GamingData.HadDestroySLCube = 0;
            GamingData.SeconLine = 0;
        }

        if (GamingData.T3Line > 10)
        {
            GamingData.Destroy3LCube = true;
        }
        if (GamingData.HadDestroy3LCube > 10)
        {
            GamingData.Destroy3LCube = false;
            GamingData.HadDestroy3LCube = 0;
            GamingData.T3Line = 0;
        }

        if (GamingData.T4Line >10)
        {
            GamingData.Destroy4LCube = true;
        }
        if (GamingData.HadDestroy4LCube > 10)
        {
            GamingData.Destroy4LCube = false;
            GamingData.HadDestroy4LCube = 0;
            GamingData.T4Line = 0;
        }

        if (GamingData.T5Line >10)
        {
            GamingData.Destroy5LCube = true;
        }
        if (GamingData.HadDestroy5LCube > 10)
        {
            GamingData.Destroy5LCube = false;
            GamingData.HadDestroy5LCube = 0;
            GamingData.T5Line = 0;
        }


    }

    private void MethodName()
    {
        if(rand==1)
        OutCube = CreatCube.creatcube(Cube1);
        if (rand == 2)
            OutCube = CreatCube.creatcube(Cube2);
        if (rand == 3)
            OutCube = CreatCube.creatcube(Cube3);
        //这里写上duration秒后要执行的内容
        CreatingCube = false;
    }

    float GetSpeed(GameObject oj)
    {
        Rigidbody rg = oj.GetComponent<Rigidbody>();
        float speed = rg.velocity.magnitude;
        return speed;
    }

}


