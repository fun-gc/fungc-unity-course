using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs / Slime.cs / Boss.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slime = new Slime();
        Boss boss = new Boss();

        slime.Attack(); // ぷよっ！
        boss.Attack();  // 体当たり → ファイアを放つ！
    }
}
