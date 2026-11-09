using UnityEngine;

// このファイルを読み込むと、hp の行がエラーになる(CS0122)。エラーが出たら成功！
// private は「そのクラスの中だけ」。子の Slime は Enemy の外なので使えない。
public class Slime : Enemy
{
    public void Hurt()
    {
        hp -= 1; // ← ここでエラー。直し方は次の 06_protected で
    }
}
