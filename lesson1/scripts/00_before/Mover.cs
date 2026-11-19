using UnityEngine;
using UnityEngine.InputSystem;

// 第2回の Mover の rb を、GetComponent で自分から取り出す形にしたもの。
// rb 欄にドラッグしなくても動く(rb 欄は Inspector から消える)。
public class Mover : MonoBehaviour
{
    private Rigidbody rb; // public をやめて private に。Start で自分で取る
    public float speed = 5f;
    private float x, z; // Update で読んだ値を、FixedUpdate で使う

    void Start()
    {
        // 自分(このスクリプトを付けた GameObject)に付いている Rigidbody を取り出す
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 入力は Update で読む(第1・2回と同じ)
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
