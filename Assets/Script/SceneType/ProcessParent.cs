using UnityEngine;
using System.Collections;

public abstract class ProcessParent : MonoBehaviour {
	
	protected SceneManager sceneManager;
	private bool mSceneRunning = false;
	public bool IsSceneRunning{
		get{ return mSceneRunning; }
	}

	void Awake(){
		sceneManager = GetComponentInParent<SceneManager>();
	}

	public virtual void SceneStart(){
		mSceneRunning = true;
	}

	public virtual void SceneEnd(){
		mSceneRunning = false;
	}

}
