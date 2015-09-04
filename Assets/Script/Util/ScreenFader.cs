using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFader : MonoBehaviour {

	private Canvas canvas;
	private Image fader;

	void Awake(){
		canvas = GetComponent<Canvas>();
		fader = GetComponentInChildren<Image>();
	}

	public void FadeIn(){
		canvas.enabled = true;
		fader.canvasRenderer.SetAlpha( 0.0f );
		fader.CrossFadeAlpha(1, 1, false);
	}

	public void FadeOut(){

		StartCoroutine(FadeOutRoutine());
	}

	IEnumerator FadeOutRoutine()
	{
		fader.CrossFadeAlpha(0, 1, false);
		yield return new WaitForSeconds(1);
		canvas.enabled = false;
	}

}
