using UnityEngine;

public class Enemy
{
    protected int hp = 10;

    public virtual void Attack()
    {
        Debug.Log("攻撃");
    }
}

