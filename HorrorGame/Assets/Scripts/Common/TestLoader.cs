using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoader : CSVLoader<TestLoader>
{
    #region public method
    /// <summary>
    /// ロードメソッド
    /// </summary>
    public void Load()
    {
        LoadData(Const.Path.DATA_DIRECTORY_PATH + Const.FileName.TestFileName + Const.Extension.CSV, LoadCallback);
    }
    #endregion


    #region private method
    /// <summary>
    /// ロードコールバックメソッド
    /// </summary>
    /// <param name="data">ロードデータ</param>
    private void LoadCallback(string data)
    {
        Debug.Log(data);
    }
    #endregion
}
