using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Time : MonoBehaviour
{

	private Text text;
	void Start ()
	{
		text = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update()
	{
		text.text = "Time: " + GetTime();
	}

	string GetTime(bool utc = false)
	{
		var time = utc ? DateTime.UtcNow : DateTime.Now;

		return time.ToString();
	}
}
