# fungc-unity-course: 第1回 入力・動作・衝突(オブジェクトを動かす)

FUN GC の Unity 講座「【Unity基礎】入力・動作・衝突を学ぼう」第1回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_try/Mover.cs` | Update の1行だけで、右へ動き続ける | 01 まず動かそう |
| `scripts/02_start-update/Mover.cs` | Start に Debug.Log を足した形 | 01 Mover.cs の中身を読もう |
| `scripts/03_input/Mover.cs` | Input System で矢印キーを x と z に読む(まだ動かさない) | 02 矢印キーの入力を読む |
| `scripts/04_speed/Mover.cs` | speed × Time.deltaTime で動く完成形 | 03 Time.deltaTime をかける |
| `scripts/05_exercise/Mover.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第1回の最初から最後までのコードが見られます。

## 使い方

1. 前回(OOP編)のプロジェクトを開き、**新しいシーンを作って保存**する(File ＞ New Scene)。Cube などは、そのシーンに新しく置く。
2. プロジェクトに前回の `Mover.cs` が残っている場合は、**先に削除**する。
3. 使うフォルダの `Mover.cs` を Project ウィンドウにドラッグ＆ドロップし、Cube にアタッチする。
4. どのフォルダにも `Mover.cs` があるので、**1つずつ、今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。

## 注意

- **ファイル名とクラス名は同じにする**(`Mover.cs` なら `class Mover`)。
- 入力は新しい Input System(`Keyboard.current`)を使う。旧い `Input.GetKey` は使わない。
- `05_exercise` は TODO を自分で書くひな型。そのままでは動かない(コンパイルは通る)。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
