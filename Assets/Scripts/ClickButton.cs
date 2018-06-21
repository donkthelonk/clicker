using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour {

	public Text currentValue;

	public long value;

	// Use this for initialization
	void Start () {
		value = 0;
		currentValue.text = value.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		value++;
		currentValue.text = value.ToString();
	}
}
