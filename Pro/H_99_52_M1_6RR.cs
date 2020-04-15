using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_99_52_M1_6RR : MonoBehaviour
{
    //M1_3preにアタッチ。オブジェクト全体のいどうをするプログラム
    //いちいちunityで当てはめなきゃ駄目　↓---------------

    //k5_3_1_1:gameobject(メソッド、変数)を使いまわす
    public H_99_01_kyoutuHensu kyotu;

    private Transform M1_6RRMove;
    void Start()
    {
        M1_6RRMove = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //meidai  m1_5 count4以下
        if (kyotu.mojiSwitch == 3 && kyotu.MCount == 5)
        {
            M1_6RRMove.position = new Vector3(10f, 0.7f, -2);
        }
        else
        {
            M1_6RRMove.position = new Vector3(16.35f, -3.74f, 0);
        }
        //Debug.Log("M1_4RRHenka::");
        //Debug.Log("M1_3RRHenka::" + kyotu.mojiSwitch + "::MC::" + kyotu.MCount + "::RRC::" + kyotu.rrCount);


    }
}
