using UnityEngine;

// 01 まず困ってみよう: Boss にも同じ hp と Move() を書いている。敵が10種類になったら……？
public class Boss
{
    int hp = 10;

    void Move() { Debug.Log("移動する"); }
    public void Fire() { Debug.Log("ファイア！"); }
}
