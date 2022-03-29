using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour,IZUpdate
{
    public GameObject cube;
    public GameObject Fathercube;
    public float Level = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        AllUpdate.AddUpdate(this);
    }

    // Update is called once per frame


    public void ZUpdate()
    {
        /*
        var v = Fathercube.transform.localPosition;
        if (v.y<-4& v.y > -5)
        {
        v.y = v.y - 0.5f;
        if(v.y<-4&v.y>-5)
        {
            Destroy(cube);
        }

        Debug.Log(v.y);
        }
        */
        var v = Fathercube.transform.localPosition;
        v.y = v.y - 0.5f;
        if (v.y < -4 & v.y > -5)
        {
            Level = 1;
        }
        if (v.y < -3 & v.y > -4)
        {
            Level = 2;
        }
        if (v.y < -2 & v.y > -3)
        {
            Level = 3;
        }
        if (v.y < -1 & v.y > -2)
        {
            Level = 4;
        }
        if (v.y < 0 & v.y > -1)
        {
            Level = 5;
        }



        if (Level == 1)
        {
            if (GamingData.DestroyFLCube)
            {
                Destroy(cube);
                GamingData.HadDestroyFLCube++;
                Debug.Log(GamingData.HadDestroyFLCube);
            }
        }
        

        if (Level == 2)
        {
            if (GamingData.DestroySLCube)
            {
                Destroy(cube);
                GamingData.HadDestroySLCube++;
            }
        }
        if (Level == 3)
        {
            if (GamingData.Destroy3LCube)
            {
                Destroy(cube);
                GamingData.HadDestroy3LCube++;
            }
        }

        if (Level == 4)
        {
            if (GamingData.Destroy4LCube)
            {
                Destroy(cube);
                GamingData.HadDestroy4LCube++;
            }
        }
        if (Level == 5)
        {
            if (GamingData.Destroy5LCube)
            {
                Destroy(cube);
                GamingData.HadDestroy5LCube++;
            }
        }

    }
    }
