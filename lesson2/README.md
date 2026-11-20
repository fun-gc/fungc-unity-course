# fungc-unity-course: 第2回 サウンドとアニメーション(絵を動かそう)

FUN GC の Unity 講座「【Unity基礎】サウンドとアニメーションを学ぼう」第2回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトと設定の一覧だけです)。
対象は FUN GC の部員です。第2回は**コードを書かない回**で、Unity エディタの操作だけで動きを作ります。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/Mover.cs` | 第1回の準備と同じ。Rigidbody で矢印キー移動(rb は GetComponent で取る) | 第1回のプロジェクトがない人の準備 |

講座の流れの順に番号を付けています(今回はスクリプトが1つだけです)。

## 使い方

1. 第1回のプロジェクトを開き、シーンを File ＞ Save As で別名保存する。
   - プロジェクトがない人は、Floor(3D Object ＞ Plane)と Cube を置き、Cube の名前を Player にして Rigidbody を付け(Freeze Rotation の X・Y・Z を ON)、`00_before/Mover.cs` を付ける。Input System パッケージが入っている前提。
2. **Player の見た目を、子の Body に分ける**(アニメーションを付けるのは Player 本体ではなく Body)。
   - Player を右クリック ＞ 3D Object ＞ Cube、名前を **Body**。Transform の Position (0, 0, 0)、Scale (1, 1, 1)。
   - Body の Box Collider は Remove Component で外す。
   - Player 本体の Mesh Renderer のチェックを外す(Box Collider・Rigidbody・Mover は残す)。
3. Project ウィンドウに `Animations` フォルダを作り、Clip と Controller はそこに保存する。
4. 講座の中で、Body を選んで Animation ウィンドウ(Window ＞ Animation ＞ Animation)から Clip を作る。Animator ウィンドウは Window ＞ Animation ＞ Animator。

## 作るもの(設定の一覧)

| 対象 | 設定 |
|---|---|
| Idle.anim | Rotation Z: 0:00 = 0 / 0:30 = 10 / 1:00 = 0、Loop Time ON |
| Walk.anim | Position Y: 0:00 = 0 / 0:10 = 0.2 / 0:20 = 0、Loop Time ON |
| Body.controller | Entry → Idle(Default State)。Idle → Walk と Walk → Idle の矢印2本。Has Exit Time は初期値(ON、Exit Time 0.75)、Conditions なし |
| Body の Animator | Controller に Body.controller |

## 注意

- **Animator を付けるのは Body**(Player 本体に Position の動きを付けると、Rigidbody と取り合って床にめり込んだり飛んだりする)。
- 録画ボタン(●)を押さずに値を変えても、キーは打たれない(エラーも出ない)。
- Animator の Controller 欄が None だと動かない(エラーなし)。Loop Time は Project で Clip を選んだときの Inspector にある。
- Animator ウィンドウは、Body を選んでいる間だけ中身が表示される。
- 第3回でも Body と Idle・Walk を使うので、このシーンを保存しておく。
- 演習の答え合わせは、講座のスライド「解答例」の設定の一覧と見比べる。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
