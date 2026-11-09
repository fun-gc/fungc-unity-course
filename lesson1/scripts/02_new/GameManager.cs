using UnityEngine;

// 空の GameObject にアタッチして再生する。
// 01_enemy-class の Enemy.cs も、同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        // new で設計図から実物(インスタンス)を作る
        Enemy slime = new Enemy();
        slime.name = "スライム";
        slime.hp = 10;

        Enemy goblin = new Enemy();
        goblin.name = "ゴブリン";
        goblin.hp = 30;

        // 同じ Attack() でも、表示される名前は実物ごとに違う
        slime.Attack();
        goblin.Attack();

        // NG(CS0120): クラス名に直接値は入れられない
        // Enemy.hp = 10;
    }
}
