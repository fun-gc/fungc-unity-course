using UnityEngine;

public class Boss : Enemy
{
    public override void Attack()
    {
        base.Attack();
        Debug.Log("ファイア！");
    }
}

