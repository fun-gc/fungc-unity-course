using UnityEngine;

// 体験: キューブに付けて再生すると、右へ動き続ける。停止すると元の位置に戻る。
public class Mover : MonoBehaviour
{
    void Update()
    {
        transform.position +=
            new Vector3(0.01f, 0, 0);
    }
}
