using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PageIntro : PageParent {

	public Image vsImage;
	public ParticleSystem particle;

	public override void PageStart ()
	{
		base.PageStart ();
		vsImage.canvasRenderer.SetAlpha( 0f );

		StartCoroutine(Routine());
	}
	
	public override void PageEnd ()
	{
		base.PageEnd ();
		vsImage.canvasRenderer.SetAlpha( 0f );
	}
	
	IEnumerator Routine(){

		yield return new WaitForSeconds(1f);

		vsImage.CrossFadeAlpha(1, 0.5f, true);
		yield return new WaitForSeconds(0.6f);

		particle.Play(true);
		yield return new WaitForSeconds(1.4f);

		vsImage.CrossFadeAlpha(0, 0.5f, true);
		yield return new WaitForSeconds(0.5f);

		
	}

}
