using UnityEngine;

// 前回(第0回)の Mover.cs の完成形。
// 第1回のキューブ(Prefab にするもの)に付ける。前回の演習が終わらなかった人も、これで先に進める。
public class Mover : MonoBehaviour
{
    public float speed = 5f;

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
}
