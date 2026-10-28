using UnityEngine;

// Start は再生を始めたとき1回だけ、Update は毎フレーム呼ばれる。
// 再生すると Console に「スタート！」が1回だけ出る。
public class Mover : MonoBehaviour
{
    void Start()
    {
        Debug.Log("スタート！");
    }

    void Update()
    {
        transform.position += new Vector3(0.01f, 0, 0);
    }
}
