using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	// References to on-screen text elements
	public Text ClickCount;
	public Text ScienceCount;

	// Variables to hold counts
	private long numClicks;
	private long numScience;
	
	// Variables to hold costs for store listings
	public int costPlusOneClickPerSec;
	public int costPlusOneSciencePerSec;

	// Use this for initialization
	void Start () {
		numClicks = 0;
		numScience = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Behavior for clicking the click button
	public void OnClickButton() {
		numClicks++;
		ClickCount.text = numClicks.ToString();
	}

	// Behavior for clicking +1 Clicks/sec button
	public void OnBuyPlusOneClickPerSec(){
		if(numClicks >= costPlusOneClickPerSec){
			numClicks = numClicks - costPlusOneClickPerSec;
			InvokeRepeating("IncClickCountByOne", 1.0f, 1.0f);
		}
	}

	// Behavior for clicking +1 Science/sec button
	public void OnBuyPlusOneSciencePerSec(){
		if(numClicks >= costPlusOneSciencePerSec){
			numClicks = numClicks - costPlusOneSciencePerSec;
			InvokeRepeating("IncScienceCountByOne", 1.0f, 1.0f);
		}
	}

	// Increment Click Count by 1
	private void IncClickCountByOne(){
		numClicks++;
		ClickCount.text = numClicks.ToString();
	}

	// Increment Science Count by 1
	private void IncScienceCountByOne(){
		numScience++;
		ScienceCount.text = numScience.ToString();
	}
}
