using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T0014M_moveYokoPanelSwipe : MonoBehaviour
{
    //縦移動のみスワイプ--------------------
    //縦移動のみフリック
    //tupしていた時間を得るプログラム
    //tupしていた距離を得るプログラム
    //メインカメラにアタッチ（とりあえず動きは全てメインカメラにアタッチにするか？）
    //フリック＞パブリックでMOVEパネルを当てはめる
    //フリック、スワイプともにmovepanelが上下に動く

    //パブリックでMOVEパネルを当てはめる
    //この透明のパネルの子にmojipanelが並ぶ。
    //親のmovepanelが動かすことで、子のmojipanelが上下移動する
    public GameObject toumeiPanel;
    //toumeiPanelのRectTransformが入る変数
    RectTransform rtToumeiPanel;

    //縦移動のみスワイプ--------------------

    //横移動
    //メインカメラを横座標に動かす（メインカメラは縦には一切動かない）
    //メインカメラにアタッチ（いずれ）
    //メインカメラをパブリックにして当てはめる

    public float yokoMove = 0;
    Transform trMainCamera;
    private void Start()
    {
        //toumeiPanelのRectTransformが入る変数当てはめる
        rtToumeiPanel = toumeiPanel.GetComponent<RectTransform>();

        //maincameraにtranceformを当てはめる
        trMainCamera=this.gameObject.GetComponent<Transform>();
    }
    Vector3 yokoFirstPoint = new Vector3(0,0,0);
    Vector3 yokoSa = new Vector3(0, 0, 0);

    void Update()
    {
        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。
        //>tupTimeHanteiに使う。>swipe()に使う
        elapse = (float)stopwatch.Elapsed.TotalSeconds;

        //k6_ac:何秒たったかを変数elapseに入れる:update内にいれる。
        //>swipe()に使う
        swipeElapse = (float)SwipeStopwatch.Elapsed.TotalSeconds;

        yokoMoveHantei();
        //Debug.Log(yokoMove);
        
        //if (yokoMove==1|| yokoMove == -1) 
        //{
        //    //Debug.Log(yokoMove);
        //    yokoCameraSwipe();
        //}
        //フリックをするメソッド
        flick();
        //スワイプをするメソッド
        //スワイプしている最中どこかをtupするとスワイプを止める。
        swipe();

        //（フリック、スワイプで）目次がある値以上の場所へ行かない処理（movemokujipanelが）
        // 全体を動かすmovemokujipanelオブジェが下へ行きすぎないように制御
        //if (rtToumeiPanel.anchoredPosition.y <= 0)
        //{
        //    rtToumeiPanel.anchoredPosition = new Vector3(0, 0, 0);
        //}
        /////全体を動かすmoveMokujiPanelより上へ行かないように制御
        //else if (rtToumeiPanel.anchoredPosition.y >= 150)
        //{
        //    rtToumeiPanel.anchoredPosition = new Vector3(0, 150, 0);
        //}
    }
    ////yokoCameraSwipe------カメラは動かさずパネルを動かす--------------------------------------------------------------------
    ////フリックをするメソッド
    ////パブリックでMOVEパネルを当てはめる
    ////なぜ途中でタップするとスワイプ終了するのかよくわからないがとにかく止まる
    ////メソッド　tupTimeHantei、tupKyoriHanteiが必要
    
    ////bool yokoCameraSwipeMove = false;
    
    ////スワイプの移動スピードを調整する変数
    //public float yokoCameraSwipeSpeed = 8.0f;
    ////最初にタップした座標が入れる
    //Vector3 yokoCameraTupFirstPoint = new Vector3(0, 0, 0);
    //int yokoPosi =0;
    //void yokoCameraSwipe()
    //{
    //    if (trMainCamera.position.x == 0) yokoPosi = 0;

    //    else if (trMainCamera.position.x == 5) yokoPosi = 5;

    //    else if (trMainCamera.position.x == 10) yokoPosi = 10;

    //    //スワイプの途中でtupした時の処理
    //    //yokoCameraSwipeMove = true;

    //    //maincameraが目次パネルにあったら（world0にあったら）
    //    if (0<=trMainCamera.position.x && trMainCamera.position.x<5)
    //    {
            
    //        //maincameraをworld５まで移動
    //        //移動実施
    //        trMainCamera.position += new Vector3(yokoMove*yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);
            
    //        if(trMainCamera.position.x>=5&& yokoMove==1)
    //        {
    //            trMainCamera.position = new Vector3(5, 0, -10);
    //            yokoMove = 0;
    //            //Debug.Log("soto?" + yokoMove);
    //        }
    //        else if (trMainCamera.position.x <= 0&& yokoMove == -1) 
    //        {
    //            trMainCamera.position = new Vector3(0, 0, -10);
    //            yokoMove = 0;
    //        }
            
    //    }
    //    else if (5 <= trMainCamera.position.x && trMainCamera.position.x < 10)
    //    {
    //        //maincameraがフラッグパネルにあったら（world5にあったら）


    //        //Debug.Log("kokokita?" + yokoMove);
    //        //maincameraをworld５まで移動
            
    //        //移動実施
    //        trMainCamera.position += new Vector3(yokoMove * yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);
            
    //        if(trMainCamera.position.x>10&& yokoMove == 1)
    //        {
    //            trMainCamera.position = new Vector3(10, 0, -10);
    //            yokoMove = 0;
    //        }
    //        else if (trMainCamera.position.x < 5 && yokoMove == -1&& yokoPosi == 10)
    //        {
    //            trMainCamera.position = new Vector3(5, 0, -10);
    //            yokoMove = 0;
    //        }

    //    }
    //    else if (10 <= trMainCamera.position.x)
    //    {
    //        //maincameraがフラッグパネルにあったら（world5にあったら）


    //        //Debug.Log("kokokita?" + yokoMove);
    //        //maincameraをworld５まで移動

    //        //移動実施
    //        trMainCamera.position += new Vector3(yokoMove * yokoCameraSwipeSpeed * Time.deltaTime, 0, 0);

    //        if (trMainCamera.position.x > 10 && yokoMove == 1)
    //        {
    //            trMainCamera.position = new Vector3(10, 0, -10);
    //            yokoMove = 0;
    //        }
    //        //else if (trMainCamera.position.x < 5 && yokoMove == -1) 
    //        //{
    //        //    trMainCamera.position = new Vector3(5, 0, -10);
    //        //    yokoMove = 0;
    //        //}
    //    }
    //}
    ////yokoCameraswipe-----end---------------------------------------------------------------------
    //yokoMoveHantei-----------------------------------------------------------
    Vector3 yokopMoveHanteiFirstPoint = new Vector3(0, 0, 0);
    Vector3 yokopMoveHanteiSa = new Vector3(0, 0, 0);
    void yokoMoveHantei()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            yokoMove = 0;
            yokopMoveHanteiFirstPoint =Input.mousePosition;
        }
        if (Input.GetMouseButton(0)) 
        {
            yokopMoveHanteiSa = Input.mousePosition- yokopMoveHanteiFirstPoint;

            if(yokopMoveHanteiSa.x==0) 
            {
                yokoMove = 0;
            }
            else if (yokopMoveHanteiSa.y==0) 
            {
                if (yokopMoveHanteiSa.x > 0) 
                { 
                    yokoMove = -1;
                }
                else 
                {
                    yokoMove = 1;
                }

            }
            else 
            { 
                if(-0.3<= yokopMoveHanteiSa.y / yokopMoveHanteiSa.x 
                    && yokopMoveHanteiSa.y/ yokopMoveHanteiSa.x <= 0.3) 
                {
                    if (yokopMoveHanteiSa.x > 0)
                    {
                        yokoMove = -1;
                    }
                    else
                    {
                        yokoMove = 1;
                    }
                    //Debug.Log(yokoMove);
                }
            }
        }
    }

    //yokoMoveHantei-----------end---------------------------------------------


    //swipe------カメラは動かさずパネルを動かす--------------------------------------------------------------------
    //フリックをするメソッド
    //パブリックでMOVEパネルを当てはめる
    //なぜ途中でタップするとスワイプ終了するのかよくわからないがとにかく止まる
    //メソッド　tupTimeHantei、tupKyoriHanteiが必要
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch SwipeStopwatch
        = new System.Diagnostics.Stopwatch();
    //flick処理の時間を入れる変数ストップウォッチをつかう
    float swipeElapse;
    //スワイプをして良いか判定する変数
    bool swipeMove = false;
    //スワイプして動く時間が入る変数
    public float swipeJikan = 1f;
    //スワイプの移動スピードを調整する変数
    public float swipeSpeed = 4.0f;
    //最初にタップした座標が入れる
    Vector3 tupFirstPoint = new Vector3(0, 0, 0);
    void swipe()
    {
        //最初にタップした座標が入る
        if (Input.GetMouseButtonDown(0))
        {
            tupFirstPoint = Input.mousePosition;
            //スワイプの途中でtupした時の処理
            swipeMove = false;
            SwipeStopwatch.Reset();
            SwipeStopwatch.Stop();

        }
        //tupUPした瞬間がtup時間が0.35秒以内だった瞬間のみtimeHanteiが１、他は0になるメソッド
        tupTimeHantei();
        //tup down up  した時の距離がスクリーンポイント100以上だったら
        //kyoriHanteiが１、他は０になるメソッド
        //world座標でなく、スクリーン座標で距離を得る
        tupKyoriHantei();
        //Debug.Log("timehantei?;;"+ timeHantei+"kyorihantei;;" + kyoriHantei);
        //timeHantei * kyoriHanteiが１ならばスワイプする。
        if (timeHantei * kyoriHantei == 1)
        {
            swipeMove = true;
            //Debug.Log("kokokuru");
        }
        //swipeMoveがtrueならば
        if (swipeMove == true)
        {
            Vector3 diff = tupFirstPoint - Input.mousePosition;
            SwipeStopwatch.Start();
            //スワイプ時間以内ならば
            if (swipeJikan > swipeElapse)
            {
                //横移動判定がなければ
                if (yokoMove == 0)
                //移動実施
                rtToumeiPanel.anchoredPosition += new Vector2(0, -swipeSpeed * diff.y * Time.deltaTime);
            }
            //スワイプ時間外ならば
            else
            {
                swipeMove = false;
                SwipeStopwatch.Reset();
                SwipeStopwatch.Stop();
            }
        }

    }
    //swipe-----end---------------------------------------------------------------------
    //tupTimeHantei-------------------------------------------------------------------------------
    //tupしてから指を離した時、その時間が0.35秒以内だった瞬間だけ
    //変数timeHanteiが1、その他はtimeHanteiが0になるメソッド
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    private System.Diagnostics.Stopwatch stopwatch
        = new System.Diagnostics.Stopwatch();

    //tupしてから指を放すまで何秒たったかを変数elapseに入れる。ストップウォッチ
    private float elapse;
    //tupしてから指を離した時、その時間が0.35秒以内だった瞬間だけ
    //変数timeHanteiが1、その他はtimeHanteiが0
    int timeHantei = 0;

    void tupTimeHantei()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timeHantei = 0;
            stopwatch.Start();
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (elapse <= 0.35)
            {
                timeHantei = 1;
            }
            else
            {
                timeHantei = 0;
            }
            stopwatch.Reset();
            stopwatch.Stop();
            //Debug.Log("kokokuru?::"+elapse);
        }
        else//tup　upしてない時はtimeHantei常に0 
        {
            timeHantei = 0;
        }
    }
    //tupTimeHantei---end----------------------------------------------------------------------------
    //tupTime-------------------------------------------------------------------------------
    //tupした時間をelapseに入れるメソッド
    //k6_a:ストップウォッチ関数を使う時のおまじない。
    //private System.Diagnostics.Stopwatch stopwatch
    //    = new System.Diagnostics.Stopwatch();

    //// 何秒たったかを変数elapseに入れる。ストップウォッチ
    //private float elapse;

    //void tupTime()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        stopwatch.Start();
    //    }
    //    if (Input.GetMouseButtonUp(0))
    //    {

    //        stopwatch.Reset();
    //    }
    //    //Debug.Log(elapse);
    //}

    //tupTime---end----------------------------------------------------------------------------
    //tupKyoriHantei--------------------------------------------------------------------------
    //tup down up  した時の距離がスクリーンポイント100以上だったら
    //kyoriHanteiが１、他は０になるメソッド
    //スクリーンポイントをkyoriに値を入れる
    //縦、横とも移動はメインカメラが動くので
    //world座標でなく、スクリーン座標で距離を得る

    Vector3 kyoriDown = new Vector3(0, 0, 0);
    Vector3 kyori = new Vector3(0, 0, 0);
    int kyoriHantei = 0;
    void tupKyoriHantei()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kyoriDown = Input.mousePosition;
            kyoriHantei = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            kyori = Input.mousePosition - kyoriDown;
            if (kyori.y >= 100 || kyori.y <= -100)
            {
                kyoriHantei = 1;
            }
            //Debug.Log("kyori::" + kyori + "hantei::" + kyoriHantei);
        }
        else
        {
            kyoriHantei = 0;
        }

    }
    //tupKyoriHantei---end-----------------------------------------------------------------------
    //tupDistance--------------------------------------------------------------------------
    // tup up downの距離を得るメソッド
    //スクリーンポイントをkyoriに値を入れる
    //縦、横とも移動はメインカメラが動くので
    //world座標でなく、スクリーン座標で距離を得る

    //Vector3 kyoriDown = new Vector3(0, 0, 0);
    //Vector3 kyori = new Vector3(0, 0, 0);
    //bool kyoriHantei = false;
    //void tupDistance()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        kyoriDown = Input.mousePosition;
    //        kyoriHantei = false;
    //    }
    //    if (Input.GetMouseButton(0))
    //    {
    //        kyori = Input.mousePosition - kyoriDown;
    //        if (kyori.y>=100|| kyori.y <= -100) 
    //        {
    //            kyoriHantei = true;
    //        }
    //        //Debug.Log("kyori::" + kyori + "hantei::" + kyoriHantei);

    //    }
    //}
    //tupDistance---end-----------------------------------------------------------------------

    //flick------カメラは動かさずパネルを動かす--------------------------------------------------------------------
    //フリックをするメソッド

    Vector3 tupDown = new Vector3(0, 0, 0);
    Vector3 diff = new Vector3(0, 0, 0);

    void flick()
    {
        //k3_a:Input.mousePosition.ToString()でマウスのスクリーンポイント表示
        //k3_zz2_a:スクリーン座標＞ワールド座標
        if (Input.GetMouseButtonDown(0))
        {
            tupDown = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            if (tupDown != Input.mousePosition)
            {
                Vector3 diff = Input.mousePosition - tupDown;
                //横移動判定がなければ
                if (yokoMove == 0) 
                
                    rtToumeiPanel.anchoredPosition
                    = new Vector2(0, rtToumeiPanel.anchoredPosition.y + diff.y);
                
            }
            tupDown = Input.mousePosition;
        }
    }
    //flick-----end---------------------------------------------------------------------
}