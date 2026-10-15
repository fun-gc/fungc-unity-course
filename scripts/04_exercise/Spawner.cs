using UnityEngine;

// 演習: スペースキーで敵を出そう
// ゴール: スペースを押すたびにキューブが増え、矢印キーで動かすと1体ずつ速さが違う
// 手順1〜3は 03_prefab と同じ。手順4の TODO を自分で書こう(答えは講座の最後に見る)
public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 手順3まではこのまま。まず Instantiate(enemyPrefab); で増えることを確認しよう
            Instantiate(enemyPrefab);

            // TODO 4: 出したキューブの speed をランダムにしよう
            //   ヒント1: Instantiate は、作った実物を返してくれる(変数で受け取れる)
            //   ヒント2: obj.GetComponent<Mover>() で、そのキューブに付いた Mover を取り出せる
            //   ヒント3: Random.Range(1f, 8f) で 1〜8 のランダムな小数
            //   形は slime.hp = 10; と同じ「インスタンス.フィールド = 値」


            // ★早く終わった人へ
            //   ・出した数を Console に表示する
            //   ・Enemy クラスに Heal() メソッドを足して、slime だけ回復させる
        }
    }
}
