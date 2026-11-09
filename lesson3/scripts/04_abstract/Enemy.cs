using UnityEngine;

// 04 abstract: 中身のない約束。親専用の設計図で、new では作れない。
public abstract class Enemy
{
    public abstract void Attack(); // 中身({ })はない。子は必ず override する
}
