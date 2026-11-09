using UnityEngine;
using UnityEngine.InputSystem;

// 演習: 壁にぶつかり、落ちるキューブ
// ゴール: 矢印キーで動くキューブが、壁にぶつかって止まり、床の端から落ちる
// 第1回の Mover をもとにした枠(using・speed・Update の読み取り)は用意済み。
// TODO 1 と TODO 2 を自分で書こう(答えは講座の最後に見る)
public class Mover : MonoBehaviour
{
    public float speed = 5f;

    // TODO 1: Rigidbody 用に、rb と x・z を用意しよう
    //   ヒント1: rb は public Rigidbody rb; と書くと、インスペクターに欄が出る(Cube 自身を入れる)
    //   ヒント2: x と z は Update と FixedUpdate の両方で使うので、メソッドの外(ここ)に private float x, z; と書く
    //   ヒント3: 外に出したら、下の Update の float x = 0f, z = 0f; は x = 0f; z = 0f; に書きかえる
    //   ヒント4: スライド「linearVelocity の y は、そのまま残す」を見ながら書いてよい


    void Update()
    {
        var kb = Keyboard.current;
        float x = 0f, z = 0f;
        if (kb.rightArrowKey.isPressed) x += 1f;
        if (kb.leftArrowKey.isPressed) x -= 1f;
        if (kb.upArrowKey.isPressed) z += 1f;
        if (kb.downArrowKey.isPressed) z -= 1f;
    }

    // TODO 2: void FixedUpdate() を書いて、rb.linearVelocity に速度を入れよう
    //   ヒント1: Update の下に void FixedUpdate() { ... } を書く
    //   ヒント2: rb.linearVelocity = new Vector3(x * speed, ?, z * speed);
    //   ヒント3: ? は、重力を残したいので、今の値のまま(rb.linearVelocity.y)
    //   ヒント4: 速度を直接書くので、Time.deltaTime はかけない
    //   ヒント5: スライド「Update と FixedUpdate は、呼ばれる間隔が違う」を見ながら書いてよい


    // ★早く終わった人へ
    //   ・Space キーでジャンプしよう(ヒント: rb.AddForce(Vector3.up * 5f, ForceMode.Impulse)、
    //     押した瞬間は kb.spaceKey.wasPressedThisFrame。これは Update で読む)
    //   ・Rigidbody の Mass を変えて、ぶつかり方を見比べよう
}
