using UnityEngine;
using UnityEngine.InputSystem;

// 演習: 歩く・ジャンプ・足音をつけよう(Mover.cs の TODO 1・TODO 2 を自分で書く)
// ゴール: 矢印キーで歩く動きになり、SPACE でジャンプの動きとジャンプ音が出て、歩くと足が着くたびに足音が鳴る
// 準備(コードなし。スライドの演習の手順を見ながら):
//   ・Animator Controller の Parameters に IsWalking(Bool)と Jump(Trigger)を作る
//   ・Jump の Clip と State を作り、Transition を足す(Idle⇄Walk は Has Exit Time オフ、Jump → Idle は Has Exit Time オン)
//   ・Walk の Clip に Animation Event(Function は FootStep)を付ける。足音は 04_footsteps の Footsteps.cs を使う
//   ・ジャンプ音は第1回の SePlayer がそのまま鳴らす
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


        // TODO 1: 矢印キーを押している間だけ、Animator の IsWalking を true にしよう
        //   ヒント1: 歩いているかは x や z が 0 でないか(x != 0f || z != 0f)
        //   ヒント2: animator.SetBool("名前", 値);  名前は Parameters からコピーすると安全


        // TODO 2: SPACE を押した瞬間に、Animator の Jump を1回引こう
        //   ヒント1: 押した瞬間だけ。Keyboard.current.spaceKey.wasPressedThisFrame(kb.spaceKey でもよい)
        //   ヒント2: animator.SetTrigger("名前");

    }

    void FixedUpdate()
    {
        // 物理(Rigidbody)は FixedUpdate で動かす。y は今の値のまま
        rb.linearVelocity = new Vector3(x * speed, rb.linearVelocity.y, z * speed);
    }

    // ★早く終わった人へ
    //   ・SetFloat で Speed(Float)を送り、Idle → Walk の条件を「Speed が 0.1 より大きい」に変えてみよう
    //   ・Footsteps.cs の FootStep で、鳴らす前に source.pitch = Random.Range(0.9f, 1.1f); を書いて、足音を少しずつ変えよう
}
