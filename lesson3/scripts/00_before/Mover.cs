using UnityEngine;
using UnityEngine.InputSystem;

// Rigidbody 版の完成形。y は今の値のまま残すので、重力がそのまま働く。
// rb 欄に、インスペクターで Cube 自身をドラッグして入れる。
public class Mover : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    private float x, z; // Update で読んだ値を、FixedUpdate で使う

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
        // 物理(Rigidbody)は FixedUpdate で動かす。y は今の値のまま
        rb.linearVelocity = new Vector3(x * speed, rb.linearVelocity.y, z * speed);
    }
}
