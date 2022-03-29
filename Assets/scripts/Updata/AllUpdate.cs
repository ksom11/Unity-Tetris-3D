using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AllUpdate : MonoBehaviour
{
    private static AllUpdate _allUpdate;
    private List<IZUpdate> updateList = new List<IZUpdate>();
    private List<IZUpdate> removeList = new List<IZUpdate>();
    private static AllUpdate allUpdate
    {
        get
        {
            if (_allUpdate == null)
            {
                try
                {
                    _allUpdate = GlobalObject.AddComponent<AllUpdate>();
                }
                catch (Exception e)
                {
                    Debug.LogError(e.ToString());
                }
            }
            return _allUpdate;
        }
    }
    public static void AddUpdate(IZUpdate update)
    {
        allUpdate.updateList.Add(update);
    }
    public static void RemoveUpdate(IZUpdate update)
    {
        allUpdate.removeList.Add(update);
    }
    private void RemoveUpdate()
    {
        while (removeList.Count > 0)
        {
            updateList.Remove(removeList[0]);
            removeList.RemoveAt(0);
        }
    }
    void Update()
    {
        RemoveUpdate();

        for (int i = 0; i < updateList.Count; i++)
        {
            if (removeList.IndexOf(updateList[i]) == -1)
            {
                if (updateList[i] == null) continue;
                updateList[i].ZUpdate();
            }
        }
    }
}
