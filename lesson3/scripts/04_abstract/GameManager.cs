using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs と Slime.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slime = new Slime();
        slime.Attack();

        // Enemy enemy = new Enemy(); // コメントを外すとエラー(CS0144): abstract は new できない
    }
}
