# fungc-unity-course: 第4回 ポリモーフィズムとインターフェース

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第4回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_try/` | `Enemy.cs`・`Slime.cs`・`Boss.cs` と `GameManager.cs`(Enemy 型の変数に Slime と Boss を入れて Attack を呼ぶ) | 01 まず動かそう |
| `scripts/02_list/` | 同じ `Enemy.cs`・`Slime.cs`・`Boss.cs` と、`List<Enemy>` と `foreach` を使う `GameManager.cs` | 02 親の型でまとめて扱う |
| `scripts/03_interface/` | `IDamageable.cs` と、それを実装した `Enemy.cs`、`Slime.cs`・`Boss.cs`、`GameManager.cs` | 03 インターフェース |
| `scripts/04_exercise/` | 演習のひな型 `IDamageable.cs`・`Enemy.cs`・`Slime.cs`・`Boss.cs`・`GameManager.cs`(TODO 1〜4 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。

## 使い方

1. Unity のプロジェクトを開く(第3回のプロジェクトでも、新しいプロジェクトでもよい)。
2. 使うフォルダの `.cs` を Project ウィンドウにドラッグ＆ドロップする。同じ名前のファイルは「置き換え」になる。
3. `GameManager` は空の GameObject にアタッチして再生し、Console を見る。`Enemy`・`Slime`・`Boss` は `new` で作って使うので、アタッチしない。
4. 同じクラス名のファイルが複数のフォルダにあるので、**1つずつ、今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。`01_try` と `02_list` に無い `IDamageable.cs` は、`03_interface` から `04_exercise` に進むときも同じ名前なので置き換えでよい。

## 期待する Console の出力

- `01_try` と `02_list`: 「ぺちぺち」「攻撃」「ファイア！」の順に出る。
- `03_interface`: 上に加えて「残り hp: 7」が出る。

## 注意

- **ファイル名とクラス名は同じにする**(`Enemy.cs` なら `class Enemy`)。
- `GameManager` は、同じフォルダの `Enemy.cs` などと組み合わせて使う。
- `hp` は第3回に合わせて `protected` にしている。
- `04_exercise` は TODO を自分で書くひな型なので、そのままでは動かない(Slime の `override` が、親に `virtual` が無くてエラーになる)。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。
