using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy slime = new Enemy();
        slime.name = "スライム";
        slime.hp = 10;

        // public なので、ありえない値も入ってしまう。エラーにならない！
        slime.hp = -999;   // HPがマイナス！？
        Debug.Log("スライムのHP: " + slime.hp);

        slime.hp = 99999;  // 不死身のスライム
        Debug.Log("スライムのHP: " + slime.hp);
    }
}
