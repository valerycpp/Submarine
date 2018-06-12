using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NameGameMainMenu : MonoBehaviour {

	public float delta1;
	public float time1;
	public float delta2;
	public float time2;

	private Outline ul;
	private Color c_on;
	private Color c_off;

	IEnumerator blink1()
	{
		ul.effectColor = c_on;
		yield return new WaitForSeconds(time1);
		ul.effectColor = c_off;
	}

	IEnumerator blink2()
	{
		ul.effectColor = c_on;
		yield return new WaitForSeconds(time2);
		ul.effectColor = c_off;
	}


	// Use this for initialization
	void Start ()
	{
		ul = GetComponent<Outline>();

		c_on = new Color(ul.effectColor.r, ul.effectColor.g, ul.effectColor.b, 1.0f);
		c_off = new Color(ul.effectColor.r, ul.effectColor.g, ul.effectColor.b, 0.0f);
		
		InvokeRepeating("blink1", 1.0f, delta1);
		InvokeRepeating("blink2", 1.0f, delta2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}