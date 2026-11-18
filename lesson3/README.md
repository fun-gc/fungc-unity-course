# fungc-unity-course: 第3回 uGUI(画面を動かそう)

FUN GC の Unity 講座「【Unity基礎】uGUIの表示・操作を学ぼう」第3回(最終回)で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。日本語フォントは第1回の README「使う素材」を見て用意してください)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/StatusView.cs`, `SettingsPanel.cs` | 第1回・第2回で配った最後の形(前回の画面がない人のため) | ふりかえり これまでに作った画面 |
| `scripts/01_item-list/` | Item.cs(1個分のデータ)と ShopManager.cs(アイテムの一覧を持つだけ) | 02 データを用意する:Item と List |
| `scripts/02_shop-row/` | 01 に、一覧から行を作る処理(ShopManager)と、行の表示(ShopRow)を足した版 | 02 行を生成する:Instantiate / ShopRow.cs:データを受け取って表示 |
| `scripts/03_buy/` | 02 に、所持金と購入ボタンの処理を足した版 | 02 購入ボタンを動かす:OnBuyClicked |
| `scripts/04_no-parent/` | わざと Instantiate の置き場所を書かない版(行が一覧に出てこない) | 02 よくあるつまずき:行が出てこない |
| `scripts/05_menu/MenuManager.cs` | 3つのパネルを切り替える | 03 パネルを切り替える:SetActive |
| `scripts/06_canvas-group/MenuManager.cs` | 05 に、CanvasGroup でショップをまとめて薄く・押せなくする関数を足した版 | 03 CanvasGroup でまとめて制御 |
| `scripts/07_exercise/` | 演習のひな型(ShopManager.cs の TODO 1、ShopRow.cs の TODO 2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第3回の最初から最後までのコードが見られます。
01〜04・07 は、**同じフォルダのファイルを組み合わせて**使います。

## 例のアイテム

ShopManager の Items に入力します。授業では上から5〜8個で十分です(Viewport を小さめにするとスクロールを確かめられます)。

| name | price | name | price |
|---|---|---|---|
| ポーション | 50 | 鉄の盾 | 400 |
| ハイポーション | 200 | 鉄の剣 | 450 |
| どくけしそう | 30 | 魔法の杖 | 800 |
| エーテル | 120 | 銀のよろい | 1000 |
| たいまつ | 20 | はやてのくつ | 600 |
| やくそう | 10 | 星のペンダント | 1500 |
| きずぐすり | 80 | ドラゴンの盾 | 2000 |
| かえりの羽 | 150 | 勇者の剣 | 3000 |
| 木の盾 | 100 | ふしぎな地図 | 250 |
| 革のよろい | 180 | 金の冠 | 5000 |

## 使い方

1. 第1回・第2回のプロジェクトを開き、シーンを File ＞ Save As で別名保存する。ステータス画面と設定画面の部品は、それぞれ **Panel の子にまとめる**(UI ＞ Panel を作って中へドラッグ)。前回の画面がない人は `00_before` を前回の README の手順でつなぐか、Panel に Text (TMP) を1つ置いただけの仮の画面で始めてよい。
2. ショップ用の Panel を作り、その中に UI ＞ Scroll View を置く。Content に Vertical Layout Group と Content Size Fitter(Vertical Fit = Preferred Size)を付ける。
3. 1行分の UI(名前と価格の Text (TMP)、購入ボタン)を組み、Project ウィンドウにドラッグして Prefab にする。Hierarchy に残った行は削除する。
4. スクリプトを Project ウィンドウにドラッグ＆ドロップする。**ShopManager と MenuManager は Canvas に**、ShopRow は**行の Prefab に**(Prefab をダブルクリックして開いてから)付ける。ShopManager をショップパネルに付けると、最初に開くまで行が作られない。
5. **同じ名前のファイルは、新しく入れずに、今のファイルの中身を書き換えて**使う(同じ名前のファイルを2つ入れるとクラスが重複してエラーになる)。
   - Project ウィンドウで今のファイルをダブルクリックしてエディタで開き、中身を全部選択して、新しい段階のファイルの中身に貼り替えて保存する。
   - ファイルを削除して入れ直すと、Inspector の欄(Items の入力、Row Prefab、Content など)と On Click の登録が消えるので、削除はしない。
   - `ShopManager.cs`: 01〜04・07
   - `ShopRow.cs`: 02〜04・07
   - `MenuManager.cs`: 05・06
   - `Item.cs`: 01〜04・07(中身はすべて同じなので、書き換えなくてよい)
6. 演習(`07_exercise`)は、ShopManager.cs と ShopRow.cs の中身を書き換える。MenuManager は 05 か 06 のものをそのまま使う。

## 注意

- **ファイル名とクラス名は同じにする**(`ShopRow.cs` なら `class ShopRow`)。Item.cs はオブジェクトに付けない。
- `04_no-parent` は**わざと**うまく動かない形です。エラーは出ませんが、行が ScrollView の中に出てきません(Hierarchy のいちばん外にできています)。03 の ShopManager.cs に戻すと直ります。
- 購入ボタンの On Click は、シーン上の行ではなく **Prefab を開いて**登録します。
- Prefab の欄に、シーン上のオブジェクトはドラッグできません(だから ShopManager は Setup で行に自分を渡しています)。
- 欄(rowPrefab、content、nameText、statusPanel、moneyText、buyButton など)を空(None)のまま再生すると、Console に NullReferenceException が出ます。
- List を使うファイルには `using System.Collections.Generic;`、文字を使うファイルには `using TMPro;`、Button を使うファイルには `using UnityEngine.UI;` が必要です(ないと CS0246)。
- `00_before` の SettingsPanel.cs は、startButton が空だと再生してすぐ(またはパネルを表示したとき)にエラーになります。
- `07_exercise` は TODO を自分で書くひな型。そのままでもコンパイルは通り、行の生成と購入(Console)は動くが、所持金の表示と購入不可は動かない。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
