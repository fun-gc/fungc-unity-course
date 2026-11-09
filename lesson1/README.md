# fungc-unity-course: 第1回 クラスとインスタンス

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第1回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_mover/Mover.cs` | 前回の Mover.cs の完成形 | 演習のキューブに付ける。前回が終わらなかった人向け |
| `scripts/01_enemy-class/Enemy.cs` | Enemy クラス(フィールドとメソッド) | 01 クラスは「設計図」 |
| `scripts/02_new/GameManager.cs` | new でインスタンスを作って使う | 02 new でインスタンスを作る |
| `scripts/03_prefab/Spawner.cs` | スペースキーで Prefab から実物を増やす | 03 Unityの中のクラス |
| `scripts/04_exercise/Spawner.cs` | 演習のひな型(手順4の TODO を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第1回の最初から最後までのコードが見られます。

## 使い方

1. 自分の Unity プロジェクトを開く(前回のキューブを使います)。
2. 使うフォルダの `.cs` を Project ウィンドウにドラッグ＆ドロップする。
3. `MonoBehaviour` のスクリプト(`Mover`、`GameManager`、`Spawner`)は GameObject にアタッチする。`Enemy` はアタッチしない。
4. `Spawner` は、`03_prefab` と `04_exercise` のどちらか**1つだけ**を入れる(クラス名が重複するため)。演習では `03_prefab` の `Spawner.cs` を `04_exercise` のもので置き換える。

## 注意

- **ファイル名とクラス名は同じにする**(`Enemy.cs` なら `class Enemy`)。
- `GameManager` を使うときは、`Enemy.cs` も同じプロジェクトに入れておく。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。キー入力は `Input.GetKey` を使うので、Project Settings → Player → Other Settings → Active Input Handling を「Both」にしてください。
