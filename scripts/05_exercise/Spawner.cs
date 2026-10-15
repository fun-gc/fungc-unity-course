using UnityEngine;

// 演習: Mover の速さを守ろう(Spawner 側)
// この Spawner.cs を読み込むと、最初は m.speed の行がエラーになる。これが手順2。
// speed を private にして守ったので、外から書こうとするとエラーになる(CS0122)。エラーが出たら成功！
public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(enemyPrefab);
            Mover m = obj.GetComponent<Mover>();

            // 手順2: ここがエラーになる(守れている証拠)
            m.speed = Random.Range(1f, 8f);

            // TODO 4: 上の m.speed の行を消して、SetSpeed を使う形に書き換えよう
            //   ヒント1: m.SetSpeed(値);
            //   ヒント2: わざと範囲外の値を渡そう。Random.Range(-5f, 15f)
            //   確認: Hierarchy で Cube(Clone) を選び、Inspector の Speed がすべて 1〜8 に収まっていれば達成


            // ★早く終わった人へ
            //   ・出した敵の速さを Console に表示する(Mover に Speed プロパティが必要)
            //   ・Enemy クラスに Heal() を足して、HP が 100 を超えないようにする
        }
    }
}
