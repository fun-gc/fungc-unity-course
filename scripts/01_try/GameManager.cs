using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy a = new Slime();
        Enemy b = new Boss();

        a.Attack();
        b.Attack();
    }
}
