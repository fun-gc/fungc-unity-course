# fungc-unity-course

FUN GC(ゲーム制作サークル)の Unity 講座で使う教材リポジトリです。
**Unity プロジェクト本体は含まれていません**。スクリプトなどの教材だけを置いています。

対象は FUN GC の部員です。

## 使い方

- 教材は**シリーズごと**に**ブランチ**で分かれています。この `main` には教材は入っていません。
- 使いたいシリーズのブランチを開き、その中の回のフォルダ(`lesson1` など)からスクリプトを自分の Unity プロジェクトにドラッグ＆ドロップして使います。
- GitHub のブランチ切り替えメニューでシリーズを選ぶか、`git clone -b <ブランチ名>` で取得できます。
- ファイル名とクラス名は同じにしてください(例: `Hello.cs` なら `class Hello`)。

## ブランチ一覧

ブランチ名は `unity-<シリーズ>` です。回ごとのフォルダは `lesson<回>` です。

| ブランチ | フォルダ | 講座 |
|---|---|---|
| [`unity-base`](../../tree/unity-base) | [`lesson0`](../../tree/unity-base/lesson0) | 【Unity基礎】オブジェクト指向をC#で学ぼう 第0回 UnityとC#の超入門 |
| [`unity-base`](../../tree/unity-base) | [`lesson1`](../../tree/unity-base/lesson1) | 同 第1回 クラスとインスタンス |
| [`unity-base`](../../tree/unity-base) | [`lesson2`](../../tree/unity-base/lesson2) | 同 第2回 カプセル化 |
| [`unity-base`](../../tree/unity-base) | [`lesson3`](../../tree/unity-base/lesson3) | 同 第3回 継承 |
| [`unity-base`](../../tree/unity-base) | [`lesson4`](../../tree/unity-base/lesson4) | 同 第4回 ポリモーフィズムとインターフェース |
| [`unity-physics`](../../tree/unity-physics) | [`lesson1`](../../tree/unity-physics/lesson1) | 【Unity基礎】入力・動作・衝突を学ぼう 第1回 オブジェクトを動かす |
| [`unity-physics`](../../tree/unity-physics) | [`lesson2`](../../tree/unity-physics/lesson2) | 同 第2回 物理的に動く、ぶつかる |
| [`unity-physics`](../../tree/unity-physics) | [`lesson3`](../../tree/unity-physics/lesson3) | 同 第3回 衝突したら何かが起きる |

講座が近くなったら、順に追加します。

## 講座シリーズ(予定)

1. 【Unity基礎】オブジェクト指向をC#で学ぼう(第0〜5回)
2. 【Unity基礎】入力・動作・衝突を学ぼう(全3回)
3. 【Unity基礎】uGUIの表示・操作を学ぼう(全3回)
4. 【Unity基礎】サウンドとアニメーション(全3回、シリーズ名は未定)

## 注意

- 演習の解答例は、講座のあとに別途配布します。
- 動作確認は Unity 6 を想定しています。
