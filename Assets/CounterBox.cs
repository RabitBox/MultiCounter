﻿using System.Collections;
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
	private Button _addButton;      // 増加ボタン
	[SerializeField]
	private Button _gainButton;     // 減少ボタン
	[SerializeField]
	private Text _nameText;         // カウントするモノの名前
	[SerializeField]
	private Text _countText;        // カウント数の表示テキストフィールド

	private int _countNumber;       // 現在のカウント

	private readonly int MAX_COUNT = 99999999;	// カウンターの最大カウント数

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	/// <summary>
	/// 名前を設定する。
	/// 初期化時のみ呼び出せるようにする。
	/// </summary>
	/// <param name="setName"></param>
	public void SetName(string setName)
	{
		if (_nameText != null)
		{
			_nameText.text = setName;
		}
	}
}