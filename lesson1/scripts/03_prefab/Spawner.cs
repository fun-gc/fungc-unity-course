using UnityEngine;

// 空の GameObject にアタッチする。Inspector の enemyPrefab 欄に Prefab をドラッグして入れる。
// スペースキーを押すたびに、Prefab から実物が1つ増える。
public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Update()
    {
        // GetKeyDown は「押した瞬間だけ」true(押しっぱなしでも1回)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab);
        }
    }
}
