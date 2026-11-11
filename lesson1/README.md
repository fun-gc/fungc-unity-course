# fungc-unity-course: 第1回 uGUI(画面を組み立てよう)

FUN GC の Unity 講座「【Unity基礎】uGUIの表示・操作を学ぼう」第1回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。枠の画像・アイコン・日本語フォントは講座で別に配ります)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_status-view/StatusView.cs` | 名前の文字を「ゆうしゃ」に、HPバーを7割にする(欄にドラッグして使う) | 02 コードから文字とバーを書き換えよう |
| `scripts/02_missing-using/StatusView.cs` | わざと `using TMPro;` を書かない版(CS0246 が出る) | 02 よくあるつまずき:TMP_Text が見つからない |
| `scripts/03_exercise/StatusView.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第1回の最初から最後までのコードが見られます。

## 使い方

1. Unity 6 で新しい 3D プロジェクトを作る(第1回は前回のシーンに依存しない)。
2. 講座で配る素材(日本語の Font Asset、枠の画像、アイコン5個)をプロジェクトに入れる。
3. Hierarchy で右クリック ＞ UI ＞ Text - TextMeshPro を置く(Canvas と EventSystem が自動で出る。初回は TMP Essentials の Import を押す)。
4. スクリプトを Project ウィンドウにドラッグ＆ドロップして、**Canvas** にアタッチする。nameText などの欄に、Text (TMP) や HPバーの Image をドラッグする。
5. **同じ名前のファイルは、1つずつ今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。`StatusView.cs` は 01・02・03 のすべてが同名。
   - 置き換えるときは、プロジェクトに残っている `StatusView.cs` を**先に削除**してから入れる。

## 注意

- **ファイル名とクラス名は同じにする**(`StatusView.cs` なら `class StatusView`)。
- `02_missing-using` は**わざと**うまく動かない形です。Console に error CS0246 が出ます(01 に置き換えると直ります)。
- 欄を空(None)のまま再生すると、Console に NullReferenceException が出ます。欄へのドラッグを忘れずに。
- HPバーの Image は、Image Type を **Filled**(Fill Method = Horizontal、Fill Origin = Left)にしないと、fillAmount を変えても伸び縮みしません。
- `03_exercise` は TODO を自分で書くひな型。そのままでもコンパイルは通るが、levelText とバーは変わらない。
- 日本語の文字は、配布した Font Asset を Text (TMP) に入れないと □ になります。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
