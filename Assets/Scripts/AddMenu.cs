using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// カウンターボックスを追加する処理を行うクラス
/// </summary>
public class AddMenu : MonoBehaviour
{
	//--------------------------------------------------
	// フィールド
	[SerializeField]
	private Button _createButton = null;	// 生成ボタン
	[SerializeField]
	private InputField _inputField = null;  // インプットフィールド

	//--------------------------------------------------
	// メソッド
	// Start is called before the first frame update
	void Start()
	{
		if (_inputField != null)
		{
			_inputField.onValueChanged.AddListener(
			   value => _createButton.interactable = (_inputField.text == string.Empty) ? false : true);
		}
		if (_createButton != null)
		{
			_createButton.onClick.AddListener(() => 
				{
					CounterManager.Instance.CreateCounterBox(_inputField.text);
					_inputField.text = string.Empty;
				});
		}
	}
}
