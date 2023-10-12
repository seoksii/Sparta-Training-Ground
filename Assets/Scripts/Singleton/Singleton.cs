using System;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static readonly object instance_lock = new object();
    private static T instance = null;
    public static T Instance
    {
        get
        {
            lock(instance_lock) {
                if (instance == null)
                {
                    instance = FindObjectOfType<T>();

                    if (instance == null)
                    {
                        GameObject singletonObject = new GameObject { name = $"@{typeof(T).ToString()}" };
                        instance = singletonObject.AddComponent<T>();
                        DontDestroyOnLoad(singletonObject);
                    }
                }
                return instance;
            }
        }
    }
}
