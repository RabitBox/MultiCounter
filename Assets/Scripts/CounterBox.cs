using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//--------------------------------------------------
// カウントボックス
//--------------------------------------------------
public class CounterBox : MonoBehaviour
{
	//--------------------------------------------------
	// フィールド
	[SerializeField]
	private Button _addButton = null;   // 増加ボタン
	[SerializeField]
	private Button _gainButton = null;  // 減少ボタン
	[SerializeField]
	private Button _closeButton = null; // カウンターボックス削除ボタン
	[SerializeField]
	private Text _nameText = null;      // カウントするモノの名前
	[SerializeField]
	private Text _countText = null;     // カウント数の表示テキストフィールド
	[SerializeField]
	private int _countNumber = 0;       // 現在のカウント

	private const int MAX_COUNT = 99999999;  // カウンターの最大カウント数

	public int CountNumber
	{
		get => _countNumber;
		private set
		{
			if (value >= 0
				&& value <= MAX_COUNT)
			{
				_countNumber = value;
				_countText.text = _countNumber.ToString();
			}
		}
	}


	//--------------------------------------------------
	// Start is called before the first frame update
	void Start()
	{
		if (_addButton != null)
		{
			_addButton.onClick.AddListener(() => CountNumber += 1);
		}
		if (_gainButton != null)
		{
			_gainButton.onClick.AddListener(() => CountNumber -= 1);
		}
		if (_closeButton != null)
		{
			_closeButton.onClick.AddListener(() => Destroy(this.gameObject));
		}
	}

	/// <summary>
	/// 名前を設定する。
	/// 初期化時のみ呼び出せるようにする。
	/// </summary>
	/// <param name="setName">設定する名前。</param>
	public void SetName(string setName)
	{
		if (_nameText != null)
		{
			_nameText.text = setName;
		}
	}

	/// <summary>
	/// ボックスに登録された、セーブに必要なデータの出力。
	/// </summary>
	/// <returns>string型のセーブに必要なデータ</returns>
	public string OutputData()
	{
		return string.Join(",", new string[] { _nameText.text, _countText.text });
	}

	/// <summary>
	/// ボックスにデータを登録する。
	/// </summary>
	/// <param name="data">入力するデータ</param>
	public void InputData(string data)
	{
		var splitData = data.Split(',');
		SetName(splitData[0]);
		CountNumber = int.Parse(splitData[1]);
	}
}
