# fungc-unity-course: 第1回 uGUI(画面を組み立てよう)

FUN GC の Unity 講座「【Unity基礎】uGUIの表示・操作を学ぼう」第1回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。画像とフォントは下の「使う素材」を見て用意してください)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_status-view/StatusView.cs` | 名前の文字を「ゆうしゃ」に、HPバーを7割にする(欄にドラッグして使う) | 02 コードから文字とバーを書き換えよう |
| `scripts/02_missing-using/StatusView.cs` | わざと `using TMPro;` を書かない版(CS0246 が出る) | 02 よくあるつまずき:TMP_Text が見つからない |
| `scripts/03_exercise/StatusView.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第1回の最初から最後までのコードが見られます。

## 使う素材

このリポジトリには画像とフォントは入っていません。次のものを各自で用意します。

| 素材 | 用意の仕方 | 使う場面 |
|---|---|---|
| 日本語フォント | [Google Fonts](https://fonts.google.com/) から Noto Sans JP などをダウンロードして Project に入れる。フォントファイルを右クリック ＞ Create ＞ TextMeshPro ＞ Font Asset で Font Asset を作る | 02 名前を日本語にすると…? |
| 枠・HPバーの画像 | Unity 標準の **UISprite**(Image の Source Image 右の ○ から選ぶ)。最初から Border が設定されている | 02 Image は、伸ばし方を選べる / 04 演習 |
| Border なしの枠画像(1枚) | [Kenney の UI Pack](https://kenney.nl/assets/ui-pack) など(CC0) | 02 Image は、伸ばし方を選べる(Sliced で端がゆがむ様子を見る) |
| アイコン5個 | [Kenney の Game Icons](https://kenney.nl/assets/game-icons) など(CC0)。なければ Image の Color を変えた四角でもよい | 03 1つ消すと、すき間が空く? / 04 演習 |

- ダウンロードした画像は、Inspector で **Texture Type を Sprite (2D and UI)** にして Apply する。
- Border は Sprite Editor で付ける。Sprite Editor が開けないときは、Package Manager で **2D Sprite** を入れる。

## 使い方

1. Unity 6 で新しい 3D プロジェクトを作る(第1回は前回のシーンに依存しない)。
2. 上の「使う素材」をプロジェクトに入れる(日本語の Font Asset を作り、画像は Texture Type を Sprite (2D and UI) にする)。
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
- 日本語の文字は、日本語の Font Asset を Text (TMP) に入れないと □ になります。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
