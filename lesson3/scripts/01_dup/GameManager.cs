using UnityEngine;

// 空の GameObject にアタッチして再生する。Slime.cs と Boss.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slime = new Slime();
        Boss boss = new Boss();

        slime.Jump();
        boss.Fire();

        // hp と Move() が Slime にも Boss にも、同じ内容で2回ずつ書かれている
    }
}
