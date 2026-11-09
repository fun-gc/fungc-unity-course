# fungc-unity-course: 第2回 カプセル化

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第2回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/` | 前回の終わりの `Enemy.cs`・`Mover.cs`・`Spawner.cs` | 前回のふりかえり。前回のプロジェクトが無い人はここから |
| `scripts/01_danger/` | `Enemy.cs`(hp が public)と `GameManager.cs` | 01 なぜデータを守るのか |
| `scripts/02_private-method/` | hp を private にして `TakeDamage` を作った `Enemy.cs` と `GameManager.cs` | 02 private とメソッドで守る |
| `scripts/03_property/` | `Hp { get; private set; }` の `Enemy.cs` と `GameManager.cs` | 03 プロパティ |
| `scripts/04_serialize/Mover.cs` | `[SerializeField] private float speed` の Mover | 04 Unityでのカプセル化 |
| `scripts/05_exercise/` | 演習のひな型 `Mover.cs`・`Spawner.cs`(TODO を自分で書く) | 05 演習 |

講座の流れの順に番号を付けています。

## 使い方

1. 前回のプロジェクトを開く(キューブの Prefab と Spawner がある状態)。
2. 使うフォルダの `.cs` を Project ウィンドウにドラッグ＆ドロップする。同じ名前のファイルは「置き換え」になる。
3. `MonoBehaviour` のスクリプト(`GameManager`、`Mover`、`Spawner`)は GameObject にアタッチする。`Enemy` はアタッチしない。
4. 同じクラス名のファイルが複数のフォルダにあるので、**1つずつ、今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。

## 注意

- **ファイル名とクラス名は同じにする**(`Enemy.cs` なら `class Enemy`)。
- `01_danger`〜`03_property` の `GameManager` は、同じフォルダの `Enemy.cs` と組み合わせて使う。
- `05_exercise/Spawner.cs` を読み込むと、最初は `m.speed` の行がエラーになる。演習の手順2なので、正しい動きです。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。キー入力は `Input.GetKey` を使うので、Project Settings → Player → Other Settings → Active Input Handling を「Both」にしてください。
