using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour {

	private CardScript[] allCards;

	void Awake(){
		allCards = CYAllCards.instance.GetComponentsInChildren<CardScript>();
	}

	public void AllCardHide(){

		foreach(CardScript item in allCards){
			item.CardHide();
		}

	}

	public void AllCardShow(){

		foreach(CardScript item in allCards){
			item.CardShow();
		}

	}


}
