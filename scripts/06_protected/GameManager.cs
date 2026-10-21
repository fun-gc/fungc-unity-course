using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs と Slime.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Slime slime = new Slime();
        slime.Hurt();
        slime.ShowHp(); // hp = 9

        // NG(CS0122): 外のクラスからは protected の hp は使えない。コメントを外して確かめよう
        // slime.hp = 99;
    }
}
