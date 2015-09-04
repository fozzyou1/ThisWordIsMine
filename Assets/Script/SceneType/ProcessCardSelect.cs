using UnityEngine;
using System.Collections;

public class ProcessCardSelect : ProcessParent {

	public Canvas canvas;

	public override void SceneStart ()
	{
		base.SceneStart ();
		canvas.enabled = true;
	}

	public override void SceneEnd ()
	{
		base.SceneEnd ();
		canvas.enabled = false;
	}

	public void StartDump(){
		sceneManager.ChangeScene(SceneManager.ProcessType.Dump);
	}

}
