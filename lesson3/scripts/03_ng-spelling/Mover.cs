using UnityEngine;
using UnityEngine.InputSystem;

// 第3回 03(わざと): Parameter の名前の綴りがちがう版。
// "Iswalking"(s が小文字)は、Animator の Parameter "IsWalking" と別の名前。
// エラーは出ず、動きも切り替わらない。Console に黄色い警告 Parameter 'Iswalking' does not exist. が出る。
// 直し方: 02 の Mover.cs の中身に貼り替える。
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
        // 入力は Update で読む(第1・2回と同じ)
        var kb = Keyboard.current;
        x = 0f;
        z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;

        // 追加: 矢印キーを押している間は true。Parameter の名前 "IsWalking" は Animator と1文字も違わないこと
        bool walking = x != 0f || z != 0f;
        animator.SetBool("Iswalking", walking); // ← わざとまちがえている
    }

    void FixedUpdate()
    {
        // 物理(Rigidbody)は FixedUpdate で動かす。y は今の値のまま
        rb.linearVelocity = new Vector3(x * speed, rb.linearVelocity.y, z * speed);
    }
}
