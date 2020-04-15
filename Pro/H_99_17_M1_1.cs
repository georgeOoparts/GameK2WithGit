using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_17_M1_1 : MonoBehaviour
{
    //オブジェsampleTriangleにアタッチ、
    //共通変数MCountによってオブジェsampleTriangleの位置を変更

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    Transform wCircleTriMove;

    void Start()
    {
        wCircleTriMove = this.gameObject.GetComponent<Transform>();


        //k5_3_1_1_1:gameobject(メソッド、変数)を使いまわす
        //Debug.Log("wCircleTriangle"+kyotu.MCount);    
    }

    void Update()
    {
        //meidai  m1_1 count5以上
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 0 && kyotu.rrCount >= 5)
        {
            wCircleTriMove.position = new Vector3(10f, 2.5f,-1);
        }
        else
        {
            wCircleTriMove.position = new Vector2(16.35f, -3.74f);
        }

    }
}
