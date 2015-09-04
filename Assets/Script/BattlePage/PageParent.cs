using UnityEngine;
using System.Collections;

public class PageParent : MonoBehaviour {
	
	protected ProcessBattle processBattle;
	protected bool pageRunning = false;

	void Awake(){
		processBattle = GetComponentInParent<ProcessBattle>();
	}

	public virtual void PageStart(){
		pageRunning = true;
	}

	public virtual void PageEnd(){
		pageRunning = false;
	}

}
