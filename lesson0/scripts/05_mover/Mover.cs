using UnityEngine;

// 演習: キューブを矢印キーで動かそう
// ゴール: 矢印キーでキューブが動き、その速さをインスペクターから変えられる
// TODO の部分を自分で書こう(答えは講座の最後に見る)
public class Mover : MonoBehaviour
{
    // TODO 2: 速さの変数を作ろう(public を付けると Inspector に出る)
    //         ヒント: public float speed = 5f;


    void Update()
    {
        // x は左右、z は前後の向き(0 なら動かない、1 と -1 は反対向き)
        float x = 0f;
        float z = 0f;

        // TODO 3: if と Input.GetKey で、矢印キーが押されているか調べよう
        //         押されていたら x や z に 1 か -1 を入れる
        //         ヒント: if (Input.GetKey(KeyCode.RightArrow)) x = 1f;
        //         (snippets/GetKey.txt も見てね)
        //         まずは右だけでOK。動いたら左・上・下も足してみよう


        // ここから下は用意済み(動かす部分。意味は演習のあとで説明するよ)
        Vector3 move = new Vector3(x, 0f, z);
        transform.position += move * speed * Time.deltaTime;

        // ★早く終わった人へ
        //   ・スペースキーでジャンプさせる
        //   ・画面の外に出たら Console に表示する
    }
}
