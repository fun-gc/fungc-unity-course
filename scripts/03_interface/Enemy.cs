using UnityEngine;

public class Enemy : IDamageable
{
    protected int hp = 10;

    public virtual void Attack()
    {
        Debug.Log("攻撃");
    }

    // IDamageable で約束したメソッド(名前と引数は約束どおり)
    public void TakeDamage(int amount)
    {
        hp -= amount;
        Debug.Log("残り hp: " + hp);
    }
}
