using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0011N_moveCamera3 : MonoBehaviour
{
    //縦移動のみスワイプ
    //移動させるメインカメラにアタッチ

    Vector3 tupDown = new Vector3(0, 0, 0);

    void Update()
    {
        //フリックをするメソッド
        flick();
    }

    //フリックをするメソッド

    void flick() 
    {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        if (Input.GetMouseButtonDown(0))
        {
            tupDown = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            if (tupDown != Camera.main.ScreenToWorldPoint(Input.mousePosition))
            {
                Vector3 diff = tupDown - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                this.gameObject.transform.position += new Vector3(0, diff.y, 0);
            }
        }
    }

    //タップ開始位置から　終了位置の距離を得るメソッド

    //タップ開始からタップ終了までの時間を得るメソッド
}
