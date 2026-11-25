using UnityEngine;
using UnityEngine.InputSystem;

// 第3回 01: Mover から Animator の Parameter を書きかえる(SetBool)。
// 00_before の Mover.cs に、animator の欄と SetBool の2行を足しただけ。
// Animator は Body(Player の子)に付いている。Mover の animator 欄には Body をドラッグする。
public class Mover : MonoBehaviour
{
    public Animator animator; // 追加: Body の Animator をドラッグ
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
        // 入力は Update で読む(「入力・動作・衝突」第1・2回と同じ)
        var kb = Keyboard.current;
        x = 0f;
        z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;

        // 追加: 矢印キーを押している間は true。Parameter の名前 "IsWalking" は Animator と1文字も違わないこと
        bool walking = x != 0f || z != 0f;
        animator.SetBool("IsWalking", walking);
    }

    void FixedUpdate()
    {
        // 物理(Rigidbody)は FixedUpdate で動かす。y は今の値のまま
        rb.linearVelocity = new Vector3(x * speed, rb.linearVelocity.y, z * speed);
    }
}
