using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
	//--------------------------------------------------
	// フィールド
	[SerializeField]
	private Button _addCounterButton;
	[SerializeField]
	private GameObject _createTarget;

	// Start is called before the first frame update
	void Start()
    {
		if (_addCounterButton != null) _addCounterButton.onClick.AddListener(() => Debug.Log("カウンター生成"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
