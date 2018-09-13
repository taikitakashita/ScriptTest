using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    // MPの初期化
    private int mp = 53;

    // 魔法用の関数
    public void Magic() {
        if ( mp >= 5) { // MPが5以上の場合魔法を利用
            // 残りのMPを5減らす
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else{　
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
}

public class Test : MonoBehaviour {

	void Start () {
        // 配列の初期化
        int[] array = {1, 2, 3, 4, 5};

        // 各要素を順番で表示
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);

        // for分で各要素を逆順で表示
        for(int i = 4; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // for文で魔法を使う関数を呼び出す
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }

    }

    void Update () {
		
	}
}
