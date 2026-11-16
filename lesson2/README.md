# fungc-unity-course: 第2回 uGUI(部品を操作しよう)

FUN GC の Unity 講座「【Unity基礎】uGUIの表示・操作を学ぼう」第2回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトだけです。日本語フォントは第1回の README「使う素材」を見て用意してください)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/01_button-log/SettingsPanel.cs` | ボタンを押すと Console に文字を出す | 01 押しても何も起きない。登録すると動く |
| `scripts/02_reset-message/SettingsPanel.cs` | ボタンを押すと画面の文字を「リセットしました」にする | 01 登録する関数を書こう |
| `scripts/03_private-ng/SettingsPanel.cs` | わざと public を付けない版(On Click の一覧に出ない) | 01 よくあるつまずき:関数が一覧に出ない |
| `scripts/04_slider-log/SettingsPanel.cs` | 02 に、スライダーの値を Console に出す関数を足した版 | 02 つまみを動かすたびに、関数が呼ばれる |
| `scripts/05_toggle-dropdown/SettingsPanel.cs` | 04 に、トグルとドロップダウンの関数を足した版 | 02 Toggle と Dropdown も同じ形 |
| `scripts/06_input-field/SettingsPanel.cs` | 05 に、名前の入力欄の関数を足した版 | 03 入力された文字を受け取ろう |
| `scripts/07_add-listener/SettingsPanel.cs` | 06 に、コードからボタンに登録する書き方を足した版 | 03 AddListener で登録しよう |
| `scripts/08_exercise/SettingsPanel.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第2回の最初から最後までのコードが見られます。

## 使い方

1. 第1回のプロジェクトを開き、新しいシーンを作る(File ＞ New Scene)。第1回のプロジェクトがなければ、Unity 6 で新しい 3D プロジェクトを作り、日本語の Font Asset を用意する(第1回の README「使う素材」)。今回のスクリプトは第1回の StatusView を使わない。
2. Hierarchy で右クリック ＞ UI ＞ Button - TextMeshPro などを置く(Canvas と EventSystem が自動で出る。**EventSystem は消さない**)。
3. Hierarchy で右クリック ＞ Create Empty で空のオブジェクトを作り、名前を SettingsPanel にする。スクリプトを Project ウィンドウにドラッグ＆ドロップして、**この空のオブジェクト**にアタッチする(第1回は Canvas に付けたが、今回は空のオブジェクト)。
4. 部品の On Click や On Value Changed の「＋」を押し、SettingsPanel のオブジェクトをドラッグして関数を選ぶ。値を受け取る関数(OnVolumeChanged など)は、一覧の上のほうにある **Dynamic** の欄から選ぶ。
5. **同じ名前のファイルは、1つずつ今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。`SettingsPanel.cs` は 01〜08 のすべてが同名。
   - 置き換えるときは、プロジェクトに残っている `SettingsPanel.cs` を**先に削除**してから入れる。
   - 削除すると、On Click などに登録した関数が外れることがある。新しいファイルを付け直したら、登録を確認する。

## 注意

- **ファイル名とクラス名は同じにする**(`SettingsPanel.cs` なら `class SettingsPanel`)。
- `03_private-ng` は**わざと**うまく動かない形です。エラーは出ませんが、On Click の一覧に OnResetClicked が出てきません(02 に置き換えると直ります)。
- On Click の一覧に出るのは **public** の関数だけです。引数が2つ以上の関数も出ません。
- 値を受け取る関数を **Static Parameters** の欄から選ぶと、Inspector に書いた値が毎回渡され、つまみを動かしても変わりません。
- 欄(messageText、volumeSlider、startButton など)を空(None)のまま再生すると、Console に NullReferenceException が出ます。`07_add-listener` は startButton が空だと、再生してすぐにエラーになります。
- Slider・Button を使うファイル(05〜08)には `using UnityEngine.UI;`、文字や入力欄を使うファイルには `using TMPro;` が必要です(ないと CS0246)。
- `08_exercise` は TODO を自分で書くひな型。そのままでもコンパイルは通るが、音量の数字と警告文は出ない。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
