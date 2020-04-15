using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_26_M1_3preRR : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_3RRMove;
    void Start()
    {
        M1_3RRMove = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_3 count4以下
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 2 && kyotu.rrCount >=1 && kyotu.rrCount <=6) {
            M1_3RRMove.position = new Vector3(9.5f, 2f,-1);
        } else {
            M1_3RRMove.position = new Vector3(16.35f, -3.74f,0);
        }
        //Debug.Log("M1_3pre::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
