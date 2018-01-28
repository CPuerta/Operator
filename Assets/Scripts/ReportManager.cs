using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public struct ReportData
{
	public string title;
	public string date;
	public string body;
}

public class ReportManager : MonoBehaviour
{

	public UnityEngine.UI.Text title;
	public UnityEngine.UI.Text date;
	public UnityEngine.UI.Text body;

	public TextAsset reportData;

	ReportData textData;
	bool textVisible = false;

	// Use this for initialization
	void Start ()
	{
		reportData = Resources.Load<TextAsset>("breifTest");
		updateReportTextFromJson(reportData);
	}

	void updateReportTextFromJson (TextAsset reportJson)
	{
		textData = JsonUtility.FromJson<ReportData>(reportData.text);

		// Update the text in the report 
		title.text = textData.title;
		date.text = textData.date;
		body.text = textData.body;
	}

	void toggleVisibility ()
	{
		if (textVisible) {
			textVisible = false;
		} else {
			textVisible = true;
		}

		title.enabled = textVisible;
		date.enabled = textVisible;
		body.enabled = textVisible;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Animator anm = GetComponentInParent<Animator>();
		Debug.Log (anm.layerCount);
		Debug.Log (anm.normlizedTime);

		if (!anm.IsInTransition(0) && textVisible == false)
		{
			toggleVisibility();
		}
	}
}
