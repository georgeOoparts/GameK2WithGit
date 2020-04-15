using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0015M_DmoveYokoPanelSwipe : MonoBehaviour
{
    //横移動
    //メインカメラを横座標に動かす（メインカメラは縦には一切動かない）
    //メインカメラにアタッチ
    //メインカメラをパブリックにして当てはめる
    //yoko移動を司る変数yokoMoveの値はT0016M_DtateFlickSwipeMeidaiで処理される
    //
    //↓メインカメラにアタッチされているのでインスぺでメインカメラ指定
    public T0016M_DtateFlickSwipeMeidai yokoMove;

    Transform trMainCamera;

    private void Start()
    {
        //maincameraにtranceformを当てはめる
        trMainCamera = this.gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        if (yokoMove.yokoMove == 1 || yokoMove.yokoMove == -1)
        {
            //Debug.Log(yokoMove);
            yokoCameraSwipe();
        }
        //Debug.Log(yokoMove.yokoMove);
    }
    //yokoCameraSwipe------横移動はメインカメラのみを動かす--------------------------------------------------------------------
    //メインカメラのx軸のみを動かして、横移動
    //メインカメラx座標0,5,10に止まる
    //横移動の移動スピードを調整する変数
    public float yokoCameraSwipeSpeed = 8.0f;
    //最初にタップした座標が入れる
    Vector3 yokoCameraTupFirstPoint = new Vector3(0, 0, 0);
    int yokoPosi = 0;
    void yokoCameraSwipe()
    {
        if (trMainCamera.position.x == 0) yokoPosi = 0;

        else if (trMainCamera.position.x == 5) yokoPosi = 5;

        else if (trMainCamera.position.x == 10) yokoPosi = 10;

        //スワイプの途中でtupした時の処理
        //yokoCameraSwipeMove = true;

        //maincameraが目次パネルにあったら（world0にあったら）
        if (0 <= trMainCamera.position.x && trMainCamera.position.x < 5)
        {

            //maincameraをworld５まで移動
            //移動実施
            trMainCamera.position += new Vector3(yokoMove.yokoMove * yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);

            if (trMainCamera.position.x >= 5 && yokoMove.yokoMove == 1)
            {
                trMainCamera.position = new Vector3(5, 0, -10);
                yokoMove.yokoMove = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 1;
                //Debug.Log("soto?" + yokoMove);
            }
            else if (trMainCamera.position.x <= 0 && yokoMove.yokoMove == -1)
            {
                trMainCamera.position = new Vector3(0, 0, -10);
                yokoMove.yokoMove = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 0;
            }

        }
        else if (5 <= trMainCamera.position.x && trMainCamera.position.x < 10)
        {
            //maincameraがフラッグパネルにあったら（world5にあったら）


            //Debug.Log("kokokita?" + yokoMove);
            //maincameraをworld５まで移動

            //移動実施
            trMainCamera.position += new Vector3(yokoMove.yokoMove * yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);

            if (trMainCamera.position.x > 10 && yokoMove.yokoMove == 1)
            {
                trMainCamera.position = new Vector3(10, 0, -10);
                yokoMove.yokoMove = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 2;

            }
            else if (trMainCamera.position.x < 5 && yokoMove.yokoMove == -1 && yokoPosi == 10)
            {
                trMainCamera.position = new Vector3(5, 0, -10);
                yokoMove.yokoMove = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 1;

            }

        }
        else if (10 <= trMainCamera.position.x)
        {
            //maincameraがフラッグパネルにあったら（world5にあったら）


            //Debug.Log("kokokita?" + yokoMove);
            //maincameraをworld５まで移動

            //移動実施
            trMainCamera.position += new Vector3(yokoMove.yokoMove * yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);

            if (trMainCamera.position.x > 10 && yokoMove.yokoMove == 1)
            {
                trMainCamera.position = new Vector3(10, 0, -10);
                yokoMove.yokoMove = 0;
                T0002M_kyotuHensu.cameraPosiNumber = 2;

            }
            //else if (trMainCamera.position.x < 5 && yokoMove == -1) 
            //{
            //    trMainCamera.position = new Vector3(5, 0, -10);
            //    yokoMove = 0;
            //}
        }
    }
    //yokoCameraswipe-----end---------------------------------------------------------------------
}
