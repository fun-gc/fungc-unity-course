using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(new Slime());
        enemies.Add(new Boss());

        foreach (Enemy e in enemies)
            e.Attack();
    }
}
