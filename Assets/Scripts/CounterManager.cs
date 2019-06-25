using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カウンターボックスの管理を行うクラス
/// 現在は追加補助のみ 05/26/19
/// </summary>
public class CounterManager : SingletonMonoBehavior<CounterManager>
{
	//--------------------------------------------------
	// フィールド
	[SerializeField, Tooltip("カウンターボックスを生成するオブジェクトのTransform")]
	private Transform _createTarget = null;

	[SerializeField, Tooltip("カウンターボックスのPrefab")]
	private GameObject _prefavCounterBox = null;

	//--------------------------------------------------
	// メソッド
	/// <summary>
	/// カウンターボックス生成処理
	/// </summary>
	/// <param name="setName">カウンターボックスに設定する名前。</param>
	public void CreateCounterBox(string setName)
	{
		var buttonData = (Instantiate(_prefavCounterBox, _createTarget) as GameObject).GetComponent<CounterBox>();
		buttonData.SetName(setName);
	}
}
