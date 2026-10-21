using UnityEngine;

// 01 まず困ってみよう: Slime にも hp と Move() を書いている。
// GameObject にアタッチはしない(new で作って使う)。Boss.cs と GameManager.cs も同じプロジェクトに入れる。
public class Slime
{
    int hp = 10;

    void Move() { Debug.Log("移動する"); }
    public void Jump() { Debug.Log("ぴょん！"); }
}
