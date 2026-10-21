using UnityEngine;

// override で Attack() を上書きする。
public class Slime : Enemy
{
    public override void Attack()
    {
        Debug.Log("ぷよっ！");
    }
}
