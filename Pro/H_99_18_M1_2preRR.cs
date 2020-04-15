using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class H_99_18_M1_2preRR : MonoBehaviour {

    //オブジェM1_2preRRにアタッチ、
    //共通変数MCountによってオブジェM1_2preRRの位置を変更

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    Transform M1_2preRRMove;

    void Start()
    {
        M1_2preRRMove = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_2 count5以上
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 1 && kyotu.rrCount >=0 && kyotu.rrCount <= 4) 
        {
            M1_2preRRMove.position = new Vector3(10f, 3f,-1);
        } else {
            M1_2preRRMove.position = new Vector2(16.35f, -3.74f);
        }
        //Debug.Log("M1_2MS::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount); 
    }
}
