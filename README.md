# fungc-unity-course: 第0回 UnityとC#の超入門

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第0回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。

## 中身

| パス | 内容 |
|---|---|
| `scripts/Hello.cs` | Start と Update で Debug.Log を表示する |
| `scripts/HelloMethod.cs` | 関数 `SayHello()` を作って2回呼ぶ |
| `scripts/HelloIf.cs` | if / else で hp によって表示を分ける |
| `scripts/HelloArgs.cs` | 補足: 関数の引数と戻り値(Greet / Add / CalcDamage) |
| `snippets/GetKey.txt` | 演習のヒント(キー入力の調べ方) |

## 使い方

1. 自分の Unity プロジェクトを開く。
2. `scripts/` の `.cs` を Project ウィンドウにドラッグ＆ドロップする。
3. Hierarchy の Cube にドラッグしてアタッチし、再生する。

## 注意

- **ファイル名とクラス名は同じにする**(`Hello.cs` なら `class Hello`)。変えるとアタッチできなくなります。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。
