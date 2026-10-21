# fungc-unity-course: 第3回 継承

FUN GC の Unity 講座「【Unity基礎】オブジェクト指向をC#で学ぼう」第3回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_dup/` | `Slime.cs`・`Boss.cs`(hp と Move() をコピーして書いている)と `GameManager.cs` | 01 まず困ってみよう |
| `scripts/02_inherit/` | `Enemy.cs`(親)・`Slime.cs`(`: Enemy`)と `GameManager.cs` | 01 継承の書き方 |
| `scripts/03_override/` | `virtual` / `override` / `base.Attack()` の `Enemy.cs`・`Slime.cs`・`Boss.cs` と `GameManager.cs` | 02 上書きと base |
| `scripts/04_abstract/` | `abstract` な `Enemy.cs` と `Slime.cs`、`GameManager.cs` | 02 abstract |
| `scripts/05_private-error/` | hp が `private` の `Enemy.cs` と、hp を使う `Slime.cs`(エラーになる) | 03 まず試そう |
| `scripts/06_protected/` | hp が `protected` の `Enemy.cs`・`Slime.cs` と `GameManager.cs` | 03 protected |
| `scripts/07_exercise/` | 演習のひな型 `Enemy.cs`・`Slime.cs`・`Boss.cs`・`GameManager.cs`(TODO を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。

## 使い方

1. Unity のプロジェクトを開く(第2回のプロジェクトでも、新しいプロジェクトでもよい)。
2. 使うフォルダの `.cs` を Project ウィンドウにドラッグ＆ドロップする。同じ名前のファイルは「置き換え」になる。
3. `GameManager` は空の GameObject にアタッチして再生する。`Enemy`・`Slime`・`Boss` は `new` で作って使うので、アタッチしない。
4. 同じクラス名のファイルが複数のフォルダにあるので、**1つずつ、今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。前のフォルダにあって次のフォルダにないファイル(例: `04_abstract` に無い `Boss.cs`)は、削除してから使う。

## 注意

- **ファイル名とクラス名は同じにする**(`Enemy.cs` なら `class Enemy`)。
- `GameManager` は、同じフォルダの `Enemy.cs` などと組み合わせて使う。
- `05_private-error/Slime.cs` を読み込むと、hp の行がエラー(CS0122)になる。講座の「まず試そう」なので、正しい動きです。直し方は `06_protected` を見る。
- `04_abstract/GameManager.cs` と `06_protected/GameManager.cs` には、コメントを外すとわざとエラーになる行がある。
- `07_exercise` は TODO を自分で書くひな型なので、そのままでは動かない(Slime・Boss が Enemy の子になっていない)。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6 で動作確認する想定です。
