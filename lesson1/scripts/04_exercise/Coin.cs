using UnityEngine;

// 演習: コインの音(Coin.cs の TODO 1・2)と、ジャンプ音(SePlayer.cs の TODO 3・4)をつけよう
// ゴール: コインに触れると音が鳴り、ゲーム開始から BGM が流れ続け、スペースキーでジャンプ音が鳴る
// 準備:
//   ・BGM 用の Audio Source は、コードなしで作る(Loop ON、Spatial Blend 0、Volume は小さめ)
//   ・効果音用の SePlayer(空の GameObject + Audio Source、Play On Awake OFF、Spatial Blend 0)を置く
//   ・Player(Rigidbody と Collider 付き)が触れる位置に、コインを宙に置く
//   ・同じフォルダの SePlayer.cs も使う(TODO 3・4)
public class Coin : MonoBehaviour
{
    // TODO 1: 鳴らす係の Audio Source と、コインの音の Clip を入れる欄を作ろう
    //   ヒント1: Inspector でドラッグして入れたいので public にする
    //   ヒント2: 型は AudioSource と AudioClip。名前は seSource・coinClip にすると TODO 2 のヒントと合う
    //   ヒント3: 書けたら Inspector に欄が2つ出る。SePlayer の Audio Source とコインの音をドラッグ


    void OnCollisionEnter(Collision collision)
    {
        // TODO 2: 効果音を鳴らしてから、コイン自身を消そう
        //   ヒント1: 重ねて鳴らすのは PlayOneShot(Clip を引数で渡す)
        //   ヒント2: 先に鳴らして、あとで Destroy(gameObject)
        //   ヒント3: スライド「効果音は PlayOneShot で重ねる」「よくあるつまずき:コインと一緒に音が消える」を見ながら書いてよい


    }

    // ★早く終わった人へ
    //   ・鳴らすたびに source.pitch を 0.9〜1.1 でランダムに変えて、同じ音でも少しずつ違う響きにしよう
    //     (ヒント: seSource.pitch = Random.Range(0.9f, 1.1f); を PlayOneShot の前に書く)
    //   ・コインを3つに増やそう(それぞれの Coin.cs に、同じ SePlayer の Audio Source をドラッグする)
}
