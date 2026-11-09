using UnityEngine;
using UnityEngine.InputSystem;

// Rigidbody 版。矢印キーは Update で読み、速度は FixedUpdate で書く。
// rb 欄に、インスペクターで Cube 自身をドラッグして入れる。
// y に 0 を入れているので、壁にはぶつかるが、重力で落ちない(次のフォルダで直す)。
public class Mover : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    private float x, z;

    void Update()
    {
        // 入力は Update で読む(第1回と同じ読み取り)
        var kb = Keyboard.current;
        x = 0f;
        z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;
    }

    void FixedUpdate()
    {
        // 物理(Rigidbody)は FixedUpdate で動かす。速度を直接書くので deltaTime は不要
        rb.linearVelocity = new Vector3(x * speed, 0, z * speed);
    }
}
