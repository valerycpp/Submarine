using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemStart : MonoBehaviour {
    public Vector2 startPos, speedVec;
	
	private RectTransform rec;
	private Vector2 needPosObj;

	// Use this for initialization
	void Start () {
		rec = GetComponent<RectTransform>();
		needPosObj = rec.anchoredPosition;
		rec.anchoredPosition = startPos;
	}
	
	// Update is called once per frame
	void Update () {

		if (speedVec.x > 0)
		{
			if (needPosObj.x > rec.anchoredPosition.x)
				rec.anchoredPosition += new Vector2(speedVec.x, 0);
		}
		else if (speedVec.x < 0)
		{
			if (needPosObj.x < rec.anchoredPosition.x)
				rec.anchoredPosition += new Vector2(speedVec.x, 0);
		}
		if (speedVec.y > 0)
		{
			if (needPosObj.y > rec.anchoredPosition.y)
				rec.anchoredPosition += new Vector2(0, speedVec.y);
		}
		else if (speedVec.y < 0)
		{
			if (needPosObj.y < rec.anchoredPosition.y)
				rec.anchoredPosition += new Vector2(0, speedVec.y);
		}
		
		
		/*if (speedVec.x > 0)
        {
			if (transform.position.x + speedVec.x > needPosObj.x)
			{
				rec.offsetMin = new Vector2(rec.offsetMin.x, 5f);
			}
			else
			{ }
        }
        else
        {
            
        }
		if (speedVec.y > 0)
        {
			
        }
        else
        {
            
        }
        if (transform.position.x != needPosObj.y)
        {
            
        }*/
	}
}
