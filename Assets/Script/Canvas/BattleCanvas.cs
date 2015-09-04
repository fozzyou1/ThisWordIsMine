using UnityEngine;
using System.Collections;

public class BattleCanvas : MonoBehaviour {

	Canvas canvas;

	void Awake(){
		canvas = GetComponent<Canvas>();
	}
	

	public void SetEnable(bool enable){
		canvas.enabled = enable;
	}
}
