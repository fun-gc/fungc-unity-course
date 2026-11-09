# fungc-unity-course: 第3回 入力・動作・衝突(衝突したら何かが起きる)

FUN GC の Unity 講座「【Unity基礎】入力・動作・衝突を学ぼう」第3回で使う教材です。
**Unity プロジェクト本体は含まれていません**(スクリプトなどの教材だけです)。
対象は FUN GC の部員です。

## 中身

| パス | 内容 | 使う場面 |
|---|---|---|
| `scripts/00_before/Mover.cs` | 第2回の完成形(入力は Update、速度は FixedUpdate。rb は欄にドラッグ) | 第2回を保存していない人の準備 |
| `scripts/01_coin/Coin.cs` | Player がぶつかったら、コインを消す | 01 ぶつかると、コインが消える / Coin.cs の中身を読もう |
| `scripts/02_destroy-this/Coin.cs` | わざと `Destroy(this)` にした版(コインが消えない) | 01 よくあるつまずき:Destroy(this) |
| `scripts/03_health/Health.cs` | HP を持つ部品(private な hp と、public な TakeDamage) | 02 ぶつかるたびに、敵の HP が減る / Health.cs の中身を読もう / 04 演習 |
| `scripts/04_attacker/Attacker.cs` | ぶつかった相手の Health を GetComponent で取り出して、ダメージを与える | 02 ぶつかるたびに、敵の HP が減る |
| `scripts/05_mover-getcomponent/Mover.cs` | rb を Start で GetComponent して取る形(rb 欄へのドラッグが不要) | 02 GetComponent で、相手の部品を取る |
| `scripts/06_null-check/Attacker.cs` | 取れたときだけ呼ぶ(`if (h != null)`) | 03 よくあるつまずき:床や壁にぶつかるとエラー |
| `scripts/07_try-get/Attacker.cs` | TryGetComponent で取ると確認を1行にした版 | 03 TryGetComponent で安全に取る |
| `scripts/08_exercise/Spike.cs` | 演習のひな型(TODO 1・2 を自分で書く) | 04 演習 |

講座の流れの順に番号を付けています。上から順に読めば、第3回の最初から最後までのコードが見られます。

## 使い方

1. 第2回のシーンを開き、**名前を付けて保存**(File ＞ Save As)する。Floor、Wall と、Rigidbody(Freeze Rotation の X・Y・Z が ON)と Mover が付いた Cube が入っているはず。
   - 第2回のシーンがない人は、Floor(3D Object ＞ Plane)と Cube を置き、Cube に Rigidbody を付けて Constraints の Freeze Rotation(X・Y・Z)にチェックを入れ、`00_before/Mover.cs` を付けて、rb 欄に Cube 自身をドラッグする。
2. Cube の名前を **Player** に変え、Inspector 左上の **Tag を Player** にする(Player の Tag は最初から用意されているので、作らなくてよい)。
3. 使うフォルダのスクリプトを Project ウィンドウにドラッグ＆ドロップして、オブジェクトにアタッチする。
   - `Coin.cs` → コイン(Sphere など)、`Health.cs` → Enemy(赤い Cube など)、`Attacker.cs` → Player、`Spike.cs` → トゲ(赤い Cube)。
4. **同じ名前のファイルは、1つずつ今のファイルと置き換えて**使う(同時に入れるとクラスが重複してエラーになる)。同じ名前のものは `Coin.cs`(01・02)、`Attacker.cs`(04・06・07)、`Mover.cs`(00・05)。
   - 置き換えるときは、プロジェクトに残っている同じ名前のファイルを**先に削除**してから入れる。
5. `Health.cs` は1つだけ入れれば、Enemy にも Player にも付けられる(演習で使い回す)。

## 注意

- **ファイル名とクラス名は同じにする**(`Coin.cs` なら `class Coin`)。
- ぶつかったことを受け取るには、両方に Collider、どちらか(動く側)に Rigidbody が必要で、**Is Trigger は OFF**(第2回と同じ)。
- `02_destroy-this` と `04_attacker` は、**わざと**うまく動かない形です。`04_attacker` は、Health の付いていない床や壁にぶつかると Console に NullReferenceException が出ます(06・07 で直す)。
- hp は private なので Inspector には出ません。Console の「HP: 2」などで確認します。
- `05_mover-getcomponent` に置き換えると、Mover の rb 欄は Inspector から消えます(コードで取るので、ドラッグ不要)。
- `08_exercise` は TODO を自分で書くひな型。そのままでは何も起きない(コンパイルは通る)。
- 演習の解答例は、講座のあとに別途配布します。
- Unity 6.3 を想定していますが、動作確認はまだしていません。
