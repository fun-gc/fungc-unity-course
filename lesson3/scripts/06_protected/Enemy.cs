using UnityEngine;

// 06 protected: 子にだけ開く。private を protected に変えるだけ。
public class Enemy
{
    protected int hp = 10;

    // 外から変えさせたいときは、これまでどおり public なメソッドを通す(第2回)
    public void ShowHp() { Debug.Log("hp = " + hp); }
}
