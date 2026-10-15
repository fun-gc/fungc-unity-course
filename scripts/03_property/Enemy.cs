using UnityEngine;

// 03 プロパティ: 「読めるけど書けない」Hp。get は誰でもOK、private set は中だけ。
public class Enemy
{
    public int Hp { get; private set; } = 100;

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp < 0) Hp = 0;
    }
}
