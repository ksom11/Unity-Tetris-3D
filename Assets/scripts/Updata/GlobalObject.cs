using UnityEngine;
public static class GlobalObject
{
    private static GameObject globalObject = null;

    public static T AddComponent<T>() where T : MonoBehaviour
    {
        T component = GlobalObj.GetComponent<T>();
        if (component == null)
        {
            component = GlobalObj.AddComponent<T>();
        }
        return component;
    }

    public static GameObject GlobalObj
    {
        get
        {
            if (globalObject == null)
            {
                globalObject = GameObject.Find("_GlobalObject");
                if (globalObject == null)
                    globalObject = new GameObject("_GlobalObject");
                Object.DontDestroyOnLoad(globalObject);
            }
            return globalObject;
        }
    }
}


public interface IZUpdate
{
    void ZUpdate();

}
