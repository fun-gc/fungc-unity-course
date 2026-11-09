# fungc-unity-course: 第2回 入力・動作・衝突(物理的に動く、ぶつかる)

FUN GC の Unity 講座「【Unity基礎】入力・動作・衝突を学ぼう」第2回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_before/Mover.cs` | 第1回の完成形(Update で transform を動かす) | 01 Rigidbody を付けて落とす / 02 壁に向かって動かす |
| `scripts/02_velocity/Mover.cs` | 入力は Update、速度は FixedUpdate。y に 0 を入れた版 | 03 速度を書きかえて動かす |
| `scripts/03_velocity-y/Mover.cs` | y は今の値のまま残す完成形 | 03 linearVelocity の y は、そのまま残す |
| `scripts/04_exercise/Mover.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第2回の最初から最後までのコードが見られます。

## 使い方

1. 第1回のシーン(Cube に Mover が付いたもの)を開き、**名前を付けて保存**(File ＞ Save As)する。第1回に出ていない人は、新しいシーンを作り、Cube を置いて `01_before/Mover.cs` を付ける。
2. シーンに **Floor**(3D Object ＞ Plane)と **Wall**(Cube を細長くのばしたもの。厚みは 0.5 くらい)を置き、Cube を床の少し上(高さ 3 くらい)に置く。
3. Cube に **Rigidbody** を追加し、**Constraints の Freeze Rotation** の X・Y・Z にチェックを入れる(倒れなくなる)。
4. 使うフォルダの `Mover.cs` を Project ウィンドウにドラッグ＆ドロップして、**今の `Mover.cs` と置き換える**(同じ名前なので、同時に入れるとクラスが重複してエラーになる)。
5. `02_velocity` 以降は、Cube を選んで、Mover の **rb 欄に Cube 自身をドラッグ**して入れる。置き換えると rb 欄は空になるので、毎回確認する。

## 注意

- **ファイル名とクラス名は同じにする**(`Mover.cs` なら `class Mover`)。
- 入力は新しい Input System(`Keyboard.current`)を使う。旧い `Input.GetKey` は使わない。
- 速度は Unity 6 の `linearVelocity`(Unity 6 より前では `velocity`)。
- Wall の Is Trigger は OFF のままにする(演習の手順 4 で ON にして違いを見たら、OFF に戻す)。
- `04_exercise` は TODO を自分で書くひな型。そのままでは動かない(コンパイルは通る)。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
