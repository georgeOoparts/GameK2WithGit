using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_34_TD1_15RR : MonoBehaviour
{
    //M1_5RRにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform TD1_15RRMove;
    void Start()
    {
        TD1_15RRMove = this.gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 2 && kyotu.MCount == 1) {
            TD1_15RRMove.position = new Vector3(10f, 2.5f, -1);
        } else {
            TD1_15RRMove.position = new Vector3(16.35f, -3.74f, 0);
        }
        //Debug.Log("TD1_15RR::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);

    }
}
