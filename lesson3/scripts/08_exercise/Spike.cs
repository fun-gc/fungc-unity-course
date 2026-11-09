using UnityEngine;

// 演習: ダメージ床を作ろう
// ゴール: トゲに触れるたびに Player の HP が減り、0 になると Player が消える
// 準備: Player に 03_health の Health.cs を付ける(新しく作らず、使い回す)。
//       赤い Cube(Spike)を床に置き、この Spike.cs を付ける。
// TODO 1 と TODO 2 を自分で書こう(答えは講座の最後に見る)
public class Spike : MonoBehaviour
{
    // ぶつかった瞬間に、Unity が1回だけ呼んでくれる
    void OnCollisionEnter(Collision collision)
    {
        // TODO 1: ぶつかった相手から、Health を取り出そう
        //   ヒント1: 相手の GameObject は collision.gameObject
        //   ヒント2: TryGetComponent<Health>(out Health h) でも、GetComponent<Health>() でもよい
        //   ヒント3: スライド「GetComponent で、相手の部品を取る」「TryGetComponent で安全に取る」を見ながら書いてよい


        // TODO 2: 取れたときだけ、TakeDamage(1) を呼ぼう
        //   ヒント1: GetComponent を使ったなら if (h != null) で確かめる
        //   ヒント2: 床や壁(Health が付いていない)にぶつかっても、Console に赤い文字が出ないか確認する

    }

    // ★早く終わった人へ
    //   ・ダメージ量を public にして、トゲごとに痛さを変えよう
    //     (ヒント: public int damage = 1; を書き、TakeDamage(damage) と呼ぶ)
    //   ・Health.cs に回復の Heal を足して、回復アイテムを作ろう
    //     (ヒント: Heal の中は hp += amount; だけ。アイテムは Coin と同じ作りで、
    //      Player の Health を取り出して Heal を呼び、自分を Destroy する)
}
