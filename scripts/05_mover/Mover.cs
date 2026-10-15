using UnityEngine;

// 演習: キューブを矢印キーで動かそう
// ゴール: 矢印キーでキューブが動き、その速さをインスペクターから変えられる
// 手順どおりに、TODO の部分を自分で書こう(答えは講座の最後に見る)
public class Mover : MonoBehaviour
{
    // TODO 2: 速さの変数を作ろう(public を付けると Inspector に出る)
    //         ヒント: public float speed = 5f;


    void Update()
    {
        // TODO 3: if と Input.GetKey で、右矢印キーが押されているか調べよう
        //         ヒント: Input.GetKey(KeyCode.RightArrow)
        //         (snippets/GetKey.txt も見てね)


        // TODO 4: 押されていたら transform.position を動かそう
        //         まずは右に動くだけでOK。動いたら左・上・下も足してみよう


        // ★早く終わった人へ
        //   ・スペースキーでジャンプさせる
        //   ・画面の外に出たら Console に表示する
    }
}
