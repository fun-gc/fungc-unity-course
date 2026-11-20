# fungc-unity-course: 第3回 サウンドとアニメーション(動きと音をつなごう)

FUN GC の Unity 講座「【Unity基礎】サウンドとアニメーションを学ぼう」第3回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。音のファイルも含まれていません)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/Mover.cs` | 入力・動作・衝突 第3回の完成形(Rigidbody で矢印キー移動)。第1回の `00_before` と同じ | 前の回のプロジェクトがない人の準備 |
| `scripts/00_before/SePlayer.cs` | 第1回の SePlayer の完成形(スペースキーでジャンプ音) | 前の回のプロジェクトがない人の準備 |
| `scripts/01_mover-bool/Mover.cs` | Mover に animator の欄と SetBool を足した版 | 02 まず動かそう:Mover.cs から動きを切り替える |
| `scripts/02_mover-set/Mover.cs` | SetBool・SetTrigger を使う版(SetFloat はコメントで入れてある) | 02 Bool・Float・Trigger を送る |
| `scripts/03_ng-spelling/Mover.cs` | Parameter の名前を**わざと**まちがえた版(何も起きない) | 02 よくあるつまずき:Parameter の名前がちがう |
| `scripts/04_footsteps/Footsteps.cs` | Animation Event から呼ばれる足音のメソッド FootStep | 03 足が着いた瞬間に音を鳴らす / 演習 |
| `scripts/05_exercise/Mover.cs` | 演習のひな型(TODO 1・TODO 2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第3回の最初から最後までのコードが見られます。
01〜03 と 05 は Mover.cs が同名です。

## 使う素材

音のファイル(足音。wav か mp3)は含まれていません。講座で配られたものか、自分で用意したものを、Project ウィンドウにドラッグ＆ドロップして取り込みます。
第1回のジャンプ音とコインの音はそのまま使います。

## 使い方

1. 第2回までのプロジェクトを開き、シーンを File ＞ Save As で別名保存する。
   - 前提: Player(Rigidbody・Mover)の子に **Body**(Cube)があり、Body に Animator(Idle と Walk の Controller)が付いている。SePlayer(Audio Source と SePlayer.cs)がシーンにある。
   - プロジェクトがない人は、第1回・第2回の教材と講座の資料で作ってから始める(`00_before` は Mover.cs と SePlayer.cs の用意だけ)。
2. Mover.cs の中身を段階に合わせて貼り替える。Player に付いている Mover の **animator 欄に Body をドラッグ**する。
3. Footsteps.cs を **Body**(Animator と同じ GameObject)に付け、source に SePlayer の Audio Source を、stepClip に足音のファイルをドラッグする。
4. Walk の Clip の足が着くフレームに Animation Event を付け、Function を `FootStep` にする。
5. **同じ名前のファイルは、新しく入れずに、今のファイルの中身を書き換えて**使う(同名を2つ入れるとクラスが重複してエラーになる)。
   - Project ウィンドウで今のファイルをダブルクリックして開き、中身を全部選択して、新しい段階のファイルの中身に貼り替えて保存する。
   - ファイルを削除して入れ直すと、Inspector の欄にドラッグした中身も消えるので、削除はしない。
   - `Mover.cs`: 01・02・03・05。

## 注意

- **ファイル名とクラス名は同じにする**(`Mover.cs` なら `class Mover`)。
- Animator の Parameters に作る名前は、コードの文字列と**1文字も違わない**ようにする(`IsWalking`、`Jump`。大文字・小文字も同じ)。
- animator 欄を空のまま再生すると、Console に NullReferenceException が出る。
- 02 の Mover.cs は SPACE で `Jump` を引く。Parameters に `Jump`(Trigger)がまだないと、SPACE を押すたびに Console に黄色い警告(Parameter 'Jump' does not exist.)が出る(動作は止まらない)。
- `03_ng-spelling` は**わざと**うまく動かない形です。エラーは出ず、歩く動きにならず、Console に警告が出ます(02 に貼り替えると直ります)。
- Animation Event の Function 欄に FootStep が出ないときは、Footsteps.cs が Animator と同じ GameObject(Body)に付いていないか、メソッドが public でない。
- `05_exercise` は TODO を自分で書くひな型。そのままでもコンパイルは通るが、歩く動きもジャンプの動きも出ない。
- 演習の解答例は、講座のあとに別途配布します(スライドの解答例ページと `02_mover-set` が対応します)。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
