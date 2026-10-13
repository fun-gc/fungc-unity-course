using UnityEngine;

public class Hello : MonoBehaviour
{
    void Start()
    {
        // ゲーム開始時に1回だけ呼ばれる
        Debug.Log("Hello, Unity!");
    }

    void Update()
    {
        // 毎フレーム呼ばれる(Console が埋まるので、確認したら消そう)
        Debug.Log("Update!");
    }
}
