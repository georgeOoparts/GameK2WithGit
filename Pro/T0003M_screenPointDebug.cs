using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0003M_screenPointDebug : MonoBehaviour
{
    //debuglogにスクリーンポイントを表示
    void Update() 
    {
        Debug.Log(Input.mousePosition);
    }
}
