﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : SingletonMonoBehavior<CounterManager>
{
	//--------------------------------------------------
	// フィールド
	[SerializeField]
	private Button _addCounterButton;
	[SerializeField]
	private Transform _createTarget;

	[SerializeField]
	private GameObject _prefavCounterBox;

	public void CreateCounterBox(string setName)
	{
		var buttonData = (Instantiate(_prefavCounterBox, _createTarget) as GameObject).GetComponent<CounterBox>();
		buttonData.SetName(setName);
	}
}
