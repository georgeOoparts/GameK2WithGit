using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0010M_moveCamera : MonoBehaviour
{
    //単純フリック
    //移動させるメインカメラにアタッチ
    
    Vector3 tupDown = new Vector3(0, 0, 0);
    
    void Update()
    {
        //フリックをするメソッド
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
                Vector3 diff = tupDown- Camera.main.ScreenToWorldPoint(Input.mousePosition);
                this.gameObject.transform.position +=diff;
            } 
        }
    }
}
