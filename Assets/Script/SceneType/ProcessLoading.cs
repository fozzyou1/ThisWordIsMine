using UnityEngine;
using System.Collections;

public class ProcessLoading : ProcessParent {

	public Canvas canvas;

	public override void SceneStart ()
	{
		base.SceneStart ();
		canvas.enabled = true;

		StartCoroutine(Routine());
	}

	public override void SceneEnd ()
	{
		base.SceneEnd ();
		canvas.enabled = false;
	}

	IEnumerator Routine(){

		yield return new WaitForSeconds(1);

		sceneManager.ChangeScene(SceneManager.ProcessType.CardSelect);

	}

}
