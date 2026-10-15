using UnityEngine;

// 01 なぜデータを守る必要があるのか: hp が public のままの Enemy。
public class Enemy
{
    public string name;
    public int hp;

    public void Attack()
    {
        Debug.Log(name + "の攻撃！");
    }
}
