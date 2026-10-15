using UnityEngine;

// 空の GameObject にアタッチして再生する。Enemy.cs も同じプロジェクトに入れておくこと。
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy slime = new Enemy();
        slime.TakeDamage(30);

        Debug.Log(slime.Hp); // OK:読める

        // NG(CS0272): private set なので、外からは書けない。コメントを外して確かめよう
        // slime.Hp = 999;
    }
}
