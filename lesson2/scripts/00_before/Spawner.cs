using UnityEngine;

// 前回(第1回)の終わりの Spawner.cs。空の GameObject にアタッチし、enemyPrefab に Prefab を入れる。
// スペースキーで Prefab から増やし、Mover の speed を外から直接書き換えている(public だからできる)。
public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(enemyPrefab);
            Mover m = obj.GetComponent<Mover>();
            m.speed = Random.Range(1f, 8f);
        }
    }
}
