using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVLoader<T> where T : class, new()
{
    #region delegate
    public delegate void LoadDataDelegate(string data);
    #endregion


    #region property
    public static T Instance
    {
        get
        {
            if (null == m_instance)
            {
                lock(m_SyncObj)
                {
                    if (null == m_instance)
                    {
                        m_instance = new T();
                    }
                }
            }
            return m_instance;
        }
    }
    #endregion


    #region private field
    private static object m_SyncObj = new object();
    private static volatile T m_instance = null;
    #endregion


    #region method
    protected void LoadData(string path, LoadDataDelegate callback)
    {
        using (StreamReader sr = new StreamReader(@path))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                callback(line);
            }
        }
    }
    #endregion
}
