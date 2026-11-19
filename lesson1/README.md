# fungc-unity-course: 第1回 サウンドとアニメーション(音を鳴らそう)

FUN GC の Unity 講座「【Unity基礎】サウンドとアニメーションを学ぼう」第1回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。音のファイルも含まれていません)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/Mover.cs` | 入力・動作・衝突 第3回の完成形(Rigidbody で矢印キー移動。rb は GetComponent で取る) | 前のシリーズのプロジェクトがない人の準備 |
| `scripts/01_se-player/SePlayer.cs` | スペースキーで Audio Source の音を鳴らす(Play) | 02 スペースキーで鳴らす |
| `scripts/02_play-vs-oneshot/SePlayer.cs` | Play と PlayOneShot を入れ替えて連打を比べる体験用(今は Play が有効) | 02 スペースキーを連打すると、音が違う |
| `scripts/03_jump-se/SePlayer.cs` | PlayOneShot でジャンプ音を鳴らす版(jumpClip) | 02 効果音は PlayOneShot で重ねる |
| `scripts/04_destroy-ng/Coin.cs` | わざとコイン自身の Audio Source で鳴らして Destroy する版(音が途中で切れる) | 02 よくあるつまずき:コインと一緒に音が消える |
| `scripts/05_coin/Coin.cs` | ぶつかったら SePlayer の Audio Source で鳴らして、コインを消す | 02 よくあるつまずき:コインと一緒に音が消える / 04 解答例:コインに触れたら鳴らす |
| `scripts/06_exercise/` | 演習のひな型(Coin.cs の TODO 1、SePlayer.cs の TODO 2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第1回の最初から最後までのコードが見られます。
01〜03 は SePlayer.cs、04〜06 は Coin.cs が同名です。

## 使う素材

音のファイル(コインの効果音、ジャンプ音、BGM。wav か mp3)は含まれていません。講座で配られたものか、自分で用意したものを、Project ウィンドウにドラッグ＆ドロップして取り込みます。

## 使い方

1. 入力・動作・衝突 第3回のプロジェクトを開き、シーンを File ＞ Save As で別名保存する。
   - プロジェクトがない人は、Floor(3D Object ＞ Plane)と Cube を置き、Cube の名前を Player にして Rigidbody を付け(Freeze Rotation の X・Y・Z を ON)、`00_before/Mover.cs` を付ける。Input System パッケージが入っている前提。
2. 空の GameObject(Create Empty)を作って **SePlayer** と名前を付け、Audio Source を付ける。BGM 用にもう1つ空の GameObject(**BgmPlayer**)と Audio Source を作る(コードは不要)。
3. スクリプトを Project ウィンドウにドラッグ＆ドロップして付ける。`SePlayer.cs` → SePlayer、`Coin.cs` → コイン(Sphere など。宙に置く)。source・seSource の欄には、SePlayer の Audio Source をドラッグ。clip の欄には音のファイルをドラッグ。
4. **同じ名前のファイルは、新しく入れずに、今のファイルの中身を書き換えて**使う(同名を2つ入れるとクラスが重複してエラーになる)。
   - Project ウィンドウで今のファイルをダブルクリックして開き、中身を全部選択して、新しい段階のファイルの中身に貼り替えて保存する。
   - ファイルを削除して入れ直すと、Inspector の欄にドラッグした中身も消えるので、削除はしない。
   - `SePlayer.cs`: 01・02・03・06。`Coin.cs`: 04・05・06。
   - 変数名が変わる所(clip → jumpClip)は、書き換えたあとの欄にもう一度ドラッグする。
5. 演習(`06_exercise`)は、Coin.cs と SePlayer.cs の2つの中身を書き換えて使う。

## 注意

- **ファイル名とクラス名は同じにする**(`SePlayer.cs` なら `class SePlayer`)。
- スクリプトを付けた欄(source、seSource、coinClip など)を空(None)のまま再生すると、Console に NullReferenceException が出る。Audio Clip が空の Audio Source は、エラーなしで何も鳴らない。
- 音が鳴らないときは、Audio Clip が入っているか、Audio Source の Mute と Volume、Game ビューの Mute Audio、Main Camera の Audio Listener(シーンに1つ。チェックが入っているか)、PC の音量を確認する。
- 効果音用の SePlayer は Play On Awake を OFF にする(ON のままだと開始と同時に鳴る)。
- `04_destroy-ng` は**わざと**うまく動かない形です。エラーは出ませんが、音が途中で切れます(05 に置き換えると直ります)。コインに Audio Source を付けて Audio Clip を入れておく必要があります。
- ぶつかったことを受け取るには、両方に Collider、どちらか(動く側)に Rigidbody が必要で、Is Trigger は OFF。
- `02_play-vs-oneshot` は、コードのコメントのとおりに A と B を入れ替えて試す。
- `06_exercise` は TODO を自分で書くひな型。そのままでもコンパイルは通るが、コインに触れても何も起きず(消えない)、ジャンプ音も鳴らない。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
