using UnityEngine;

// class 子 : 親 と書くと、親の hp と Move() を受け継ぐ。
public class Slime : Enemy
{
    // hp と Move() は Enemy から受け継ぐ(ここには書かない)

    // 子だけの機能
    public void Jump() { Debug.Log("ぴょん！"); }
}
