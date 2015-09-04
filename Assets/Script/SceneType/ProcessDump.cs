using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProcessDump : ProcessParent {

	public Canvas canvas;
	public Text description;

	public ScreenFader fader;
	public ProcessBattle processBattle;

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

	public void DebugNext(){
		StartCoroutine(LoadOpponent());
	}

	IEnumerator LoadOpponent(){

		description.text = "상대 정보를 불러오는 중입니다";
		WWW w = new WWW("http://106.248.205.164:92/CrayonGame/gamedata.txt");
		yield return w;
		
		if (!string.IsNullOrEmpty(w.error)) {
			Debug.Log(w.error);
		}else{
			print ("Card Info ->" + w.text);
		}

		fader.FadeIn();
		yield return StartCoroutine(processBattle.DataLoading());

		yield return new WaitForSeconds(1.5f);
		fader.FadeOut();
		sceneManager.ChangeScene(SceneManager.ProcessType.Battle);
	}


}
