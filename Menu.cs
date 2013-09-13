using UnityEngine;
using System.Collections;
//using GUIwrapper;


public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
		
	void OnGUI() {
		
		GUI.Label(new Rect(10, 10, 150, 110), "Stuff Here");
		
		GUI.Label (new Rect(10, 25, 150, 200), "Other Stuff here");

		#region Commented out stuff
//		LabelWrap l1 = new LabelWrap(new ArrayList(){10, 10, 150, 110}, "Stuff Here");
//		ButtonControl bc = new ButtonControl();
//		GUI.Label(l1);
		
		
//		bc.makeLabel(l1);
		
//		if(GUI.Button(bc.genericRect, "Say Hey")) print ("Hey");
//		if(GUI.Button(new Rect(guiStartX, guiStartY, buttonSizeX, buttonSizeY), "Say Hey")) print ("Hey");
		#endregion
		
		float buttonHeight = Screen.height / 5;
		float buttonWidth = Screen.width / 5;
		float yPlacing = (Screen.height / 5);
		float xPlacing = (Screen.width / 2) - (buttonWidth / 2);
		
		
		if(GUI.Button (new Rect(xPlacing, yPlacing ,buttonWidth, buttonHeight), "Play")) 
		{
			print ("loading...");
			Application.LoadLevel("05_SplitScreen");
		}
			
		if(GUI.Button (new Rect(xPlacing, yPlacing + buttonHeight , buttonWidth, buttonHeight), "Say Hey"))
		{
			print ("quiting...");
			Application.Quit();
		}
	}
}
