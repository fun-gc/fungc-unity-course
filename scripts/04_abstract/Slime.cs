using UnityEngine;

public class Slime : Enemy
{
    // Attack() を書き忘れると、コンパイルエラーになる(CS0534)。コメントアウトして確かめよう
    public override void Attack()
    {
        Debug.Log("ぷよっ！");
    }
}
