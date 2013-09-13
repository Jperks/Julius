using UnityEngine;
using System.Collections;

namespace GUIwrapper
{/*
	public class LabelWrap
	{
		public float width;
		public float height;
		public float x;
		public float y;
		public string id;
		ArrayList generic = new ArrayList (){10f,10f,100f,50f};
			
		public LabelWrap ()
		{
			id = "No id";
			
			x = (float) generic [0];
			y = (float) generic [1];
			width = (float) generic [2];
			height = (float) generic [3];
		}
		
		public LabelWrap (ArrayList arr, string id)
		{
			this.id = id;
			
			x = (float) arr [0];
			y = (float) arr [1];
			width = (float) arr [2];
			height = (float) arr [3];
		}
		
		public ArrayList dimensions
		{
			get 
			{ 
				ArrayList d = new ArrayList (){ x, y, width, height}; 
				return d;
			}
			
			set
			{
				x = (float)value[0];
				y = (float)value[1];
				width = (float)value[2];
				height = (float)value[3];
			}
		}
		
		public Rect bounds
		{
			get { return new Rect(x, y, width, height); }
			set
			{
				x = value.x;
				y = value.y;
				width = value.width;
				height = value.height;
			}
		}
		
		public ArrayList allDetails {
			get { 
				dimensions.Add (id); 
				return dimensions; 
			}
		}
	}
	
	public class ButtonControl
	{
		
		private float buttonSizeX = 100;
		private float buttonSizeY = 50;
		private float guiStartX = 50;
		private float guiStartY = 50;
		private string genericMessage = "New Button";
		public Rect genericRect;
		
		public Rect makeRect (ArrayList arr)
		{
			return new Rect ( (float)arr[0], (float)arr[1], (float)arr[3], (float)arr[4]);
		}
		
		public string setMessage {
			get{ return genericMessage; }
			set{ genericMessage = value; }
		}
		
		public ButtonControl()
		{
			genericRect = new Rect(buttonSizeX, buttonSizeY, guiStartX, guiStartY);
		}
		
		#region Labels made easy
		/// <summary>
		/// Makes a new label.
		/// </summary>
		/// <param name='r'>
		/// r requires a GUI.Rect Object to be passed
		/// </param>
		/// <param name='message'>
		/// string message to be diplays on the label
		/// </param>
		public void makeLabel (Rect r, string message)
		{
			GUI.Label (r, message);
		}
		
		public void makeLabel(LabelWrap l)
		{
			GUI.Label(new Rect((float)l.dimensions[0], (float)l.dimensions[1], (float)l.dimensions[2], (float)l.dimensions[3]), l.id);
		}
		
		/// <summary>
		/// Makes the label without defining a rectangle
		/// </summary>
		/// <param name='message'>
		/// string message to be diplays on the label
		/// </param>
		public void makeLabel (string message)
		{
			GUI.Label (genericRect, message);
		}
			
		/// <summary>
		/// Makes the label without defining a message
		/// </summary>
		/// <param name='r'>
		/// An obect of typre GUI.Rect
		/// </param>
		public void makeLabel (Rect r)
		{
			GUI.Label (r, genericMessage);
		}
			
		/// <summary>
		/// You have to define nothing. Prints with a generic message
		/// </summary>
		public void makeLabel ()
		{
			GUI.Label (genericRect, genericMessage);
		}
		#endregion
/*		
		#region Buttons made easy
			
		/// <summary>
		/// Makes the button.
		/// </summary>
		/// <param name='r'>
		/// r is for Rect
		/// </param>
		/// <param name='message'>
		/// String with whats displayed
		/// </param>
		/// <param name='method'>
		/// Give us something to do... pass a function
		/// </param>
		public void makeButton (Rect r, string message, delegate Del<T>(void method))
		{
			if (GUI.Button (r, message))
				method.DynamicInvoke ();
		}
			
		/// <summary>
		/// Makes the button. No rect needed
		/// </summary>
		/// <param name='message'>
		/// Enter a stringed message
		/// </param>
		/// <param name='method'>
		/// Pass in a function
		/// </param>
		public void makeButton (string message, Delegate method)
		{
			if (GUI.Button (genericRect, message))
				method.DynamicInvoke ();
		}
			
		/// <summary>
		/// Makes the button. No message needed
		/// </summary>
		/// <param name='r'>
		/// Pass in a Rect object
		/// </param>
		/// <param name='method'>
		/// Pass in a function for the button.
		/// </param>
		public void makeButton (Rect r, Delegate method)
		{
			if (GUI.Button (r, genericMessage))
				method.DynamicInvoke ();
		}
			
		/// <summary>
		/// Makes the button. No function, just prints to console
		/// </summary>
		/// <param name='r'>
		/// A Rect object
		/// </param>
		/// <param name='message'>
		/// the string to be displayed
		/// </param>
		public void makeButton (Rect r, string message)
		{
			if (GUI.Button (r, message))
				print (message);
		}
			
		/// <summary>
		/// Makes the button.Just supply location
		/// </summary>
		/// <param name='r'>
		/// A Rect object
		/// </param>
		public void makeButton (Rect r)
		{
			string message = "hey";
			if (GUI.Button (r, message))
				print (message);
		}
			
		/// <summary>
		/// Makes the button. Tell it what to say
		/// </summary>
		/// <param name='message'>
		/// Supply a string with what needs to be displayed.
		/// </param>
		public void makeButton (string message)
		{
			if (GUI.Button (r, message))
				print (message);
		}
			
		/// <summary>
		/// Makes the button. Just pass in a function for it
		/// </summary>
		/// <param name='method'>
		/// A delegated function
		/// </param>
		public void makeButton (Delegate method)
		{
			if (GUI.Button (genericRect, genericMessage))
				method.DynamicInvoke ();
		}
			
		/// <summary>
		/// Makes a default button.
		/// </summary>
		public void makeButton ()
		{
			if (GUI.Button (genericRect, genericMessage))
				print (genericMessage);
		}
		#endregion
*/	
//	}
	
}