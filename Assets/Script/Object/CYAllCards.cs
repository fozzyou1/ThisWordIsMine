using UnityEngine;
using System.Collections;

public class CYAllCards : MonoBehaviour {
	
	//Here is a private reference only this class can access
	private static CYAllCards _instance;
	
	//This is the public reference that other classes will use
	public static CYAllCards instance
	{
		get
		{
			//If _instance hasn't been set yet, we grab it from the scene!
			//This will only happen the first time this reference is used.
			if(_instance == null)
				_instance = GameObject.FindObjectOfType<CYAllCards>();
			return _instance;
		}
	}

}
