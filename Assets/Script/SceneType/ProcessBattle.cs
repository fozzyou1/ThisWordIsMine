using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProcessBattle : ProcessParent {

	public BattleCanvas canvas;
	public CardManager Cards;

	public Text debugText;

	private PageIntro 		pageIntro;
	private PageParent		pageParent;

	public override void SceneStart ()
	{
		base.SceneStart ();
		canvas.SetEnable(true);
		Cards.AllCardShow();

		pageIntro 		= GetComponentInChildren<PageIntro>();

		pageParent = pageIntro;
		pageParent.PageStart();

	}

	public override void SceneEnd ()
	{
		base.SceneEnd ();
		canvas.SetEnable(false);
		Cards.AllCardHide();
	}

	public void ChangePage(PageParent reqPage){
		pageParent.PageEnd();

		pageParent = reqPage;

		pageParent.PageStart();

	}

	public IEnumerator DataLoading(){

		/// WWW

		// Player


		yield return true;

	}

}
