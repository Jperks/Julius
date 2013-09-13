using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public GUISkin mySkin;
	public InputButton pauseButton;
	
	private Rect windowRect;
	private bool paused = false, waited = true;
	private int joyNum;
	
	private void Start()
	{
		windowRect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200);
		
		
		joyNum = GetComponent<MouseControllerLogic>().playerNumber;
		print(joyNum);
	}
	
	private void waiting()
	{
		waited = true;
	}
	
	private void Update()
	{
		if(waited)
		{
			if(InputManager.Instance.getWiiController(joyNum).IsDown("+"))
			{
				if(paused) paused = false;
				else paused = true;
				
				waited = false;
				Invoke("waiting", 0.3f); 
			}
		}
		
		if(paused) Time.timeScale = 0;
		else Time.timeScale = 1;
	}
	
	
	private void OnGUI()
	{
		if(paused) windowRect = GUI.Window(0, windowRect, windowFunc, "Pause Menu");
		
	}
	
	private void windowFunc(int id)
	{
		
		if(GUILayout.Button("Resume"))
		{
			paused = false;
		}
		if(GUILayout.Button ("Quit"))
		{
			Application.LoadLevel("Menu");
		}
	}
}
