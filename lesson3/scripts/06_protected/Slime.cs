using UnityEngine;

public class Slime : Enemy
{
    public void Hurt()
    {
        hp -= 1; // OK: 子からは protected の hp が使える
    }
}
