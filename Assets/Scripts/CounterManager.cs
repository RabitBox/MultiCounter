using System.Collections;
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
	private GameObject _createTarget;
}
