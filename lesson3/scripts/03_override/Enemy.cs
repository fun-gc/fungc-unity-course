using UnityEngine;

// 03 上書きと base: virtual を付けると「子が上書きしてOK」と宣言できる。
public class Enemy
{
    protected int hp = 10;

    public virtual void Attack()
    {
        Debug.Log("体当たり");
    }
}
