using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusOneClickPerSec : MonoBehaviour {

	public Text ClickCount;

	private long value;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncCountByOnePerSec(){
		InvokeRepeating("IncCountByOne", 1.0f, 1.0f);
	}

	void IncCountByOne(){
		value = long.Parse(ClickCount.text);
		value++;
		ClickCount.text = value.ToString();
	}
}
