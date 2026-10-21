using UnityEngine;

// 02 継承の基本: 共通の hp と Move() を、親の Enemy に1回だけ書く。
// hp が protected なのは 05〜06 で説明するので、今は「子から使える」とだけ覚えておこう。
public class Enemy
{
    protected int hp = 10;

    public void Move() { Debug.Log("移動する"); }
}
