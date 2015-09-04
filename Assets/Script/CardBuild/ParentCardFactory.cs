using UnityEngine;
using System.Collections;

public abstract class ParentCardFactory : MonoBehaviour {

	public CardScript CreateCard(int index){
		CardScript newCard = GetCard(index);
		newCard.Init();

		CardInstantiate(newCard.gameObject);

		return newCard;
	}

	protected abstract CardScript GetCard(int index);
	protected abstract CardScript InitCard(CardScript newCard, int index);
	protected virtual void CardInstantiate(GameObject cardObject){
		GameObject.Instantiate(cardObject);
	}

}
