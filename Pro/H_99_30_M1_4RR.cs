using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_30_M1_4RR : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_4RRMove;
    void Start()
    {
        M1_4RRMove = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_4 count4以下
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 3) {
            M1_4RRMove.position = new Vector3(10f, 2f, -1);
        } else {
            M1_4RRMove.position = new Vector3(16.35f, -3.74f, 0);
        }
        //Debug.Log("M1_4RRHenka::");
        //Debug.Log("M1_3RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);


    }
}
