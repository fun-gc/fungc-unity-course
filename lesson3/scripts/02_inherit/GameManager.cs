using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs と Slime.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slime = new Slime();

        slime.Move(); // Slime には書いていないのに、Enemy から受け継いでいる
        slime.Jump(); // Slime だけの機能

        // Enemy enemy = new Enemy();
        // enemy.Jump(); // コメントを外すとエラー: Jump() は Slime だけがもつ(Enemy には増えない)
    }
}
