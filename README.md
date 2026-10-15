# fungc-unity-course: 第0回 UnityとC#の超入門

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第0回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。

## 中身

| パス | 内容 |
|---|---|
| `scripts/01_start-update/Hello.cs` | Start と Update で Debug.Log を表示する |
| `scripts/02_method/Hello.cs` | 関数 `SayHello()` を作って2回呼ぶ |
| `scripts/03_if/Hello.cs` | if / else で hp によって表示を分ける |
| `scripts/04_args/Hello.cs` | 補足: 関数の引数と戻り値(Greet / Add / CalcDamage) |
| `scripts/05_mover/Mover.cs` | 演習のひな型(TODO を自分で埋める。解答例は講座のあとに配布) |
| `snippets/GetKey.txt` | 演習のヒント(キー入力の調べ方) |

`01`〜`04` のフォルダは、講座資料と同じ `Hello.cs`(`class Hello`)です。`05_mover` は演習用の別ファイル `Mover.cs` で、`Hello.cs` とは別に使います。講座では1つの `Hello.cs` に書き足していくので、
資料の段階に合わせて**1つずつ、今の `Hello.cs` の中身と置き換えて**使ってください。
複数の `Hello.cs` を同じプロジェクトに入れると、クラス名が重複してエラーになります。

## 使い方

1. 自分の Unity プロジェクトを開く。
2. 使う段階のフォルダの `Hello.cs` を開き、中身を自分の `Hello.cs` にコピーする(またはドラッグ＆ドロップで置き換える)。
3. `Hello.cs` が Hierarchy の Cube にアタッチされていることを確認して、再生する。

## 注意

- **ファイル名とクラス名は同じにする**(`Hello.cs` なら `class Hello`)。変えるとアタッチできなくなります。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。
