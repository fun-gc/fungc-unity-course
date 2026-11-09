using UnityEngine;

// 演習: Mover の速さを守ろう
// ゴール: Spawner が変な値を渡しても、キューブの速さが 1〜8 の間に収まる
// 手順1(speed を [SerializeField] private にする)はやってあります。手順3の TODO を自分で書こう(答えは講座の最後に見る)
public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // TODO 3: 外から速さを変えるための入口 SetSpeed を作ろう
    //   ヒント1: public void SetSpeed(float value) { ... } の形
    //   ヒント2: value が 1 より小さければ 1 にする
    //   ヒント3: value が 8 より大きければ 8 にする
    //   ヒント4: 最後に speed = value;


    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) x = 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) x = -1f;
        if (Input.GetKey(KeyCode.UpArrow)) z = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) z = -1f;

        Vector3 move = new Vector3(x, 0f, z);
        transform.position += move * speed * Time.deltaTime;
    }

    // ★早く終わった人へ
    //   ・読むだけの Speed プロパティを作る(public float Speed { get; ... } を思い出そう)
}
