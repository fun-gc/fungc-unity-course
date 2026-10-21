using UnityEngine;

// TODO 1: IDamageable を実装しよう(: IDamageable を付ける)
public class Enemy
{
    protected int hp = 10;

    // TODO 1: 子が上書きできるように virtual を付けよう
    public void Attack()
    {
        Debug.Log("攻撃");
    }

    // TODO 1: IDamageable で約束した TakeDamage(int amount) を書こう
    //         (hp を amount だけ減らして Debug.Log で表示する)
}
