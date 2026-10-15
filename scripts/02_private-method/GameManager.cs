using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy slime = new Enemy();

        // 入口のメソッドを通して「お願い」する
        slime.TakeDamage(30);
        slime.TakeDamage(500); // やりすぎても 0 で止まる

        // NG(CS0122): private なので外から直接は書けない。コメントを外して、エラーが出ることを確かめよう
        // slime.hp = -999;
    }
}
