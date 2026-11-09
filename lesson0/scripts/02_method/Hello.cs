using UnityEngine;

public class Hello : MonoBehaviour
{
    void Start()
    {
        // 作った関数を名前で呼ぶ(2回呼べば2回表示される)
        SayHello();
        SayHello();
    }

    // 処理のまとまりに名前を付ける。Start の外(class の中)に書く
    void SayHello()
    {
        Debug.Log("こんにちは！");
    }
}
