using UnityEngine;
using System.Collections;

public class HeroCardFactory : ParentCardFactory {

	protected override CardScript GetCard (int index)
	{
		GameObject newCard;
		newCard = Resources.Load("Cards/HeroCard" + index.ToString("0000")) as GameObject;

		return newCard.GetComponent<CardScript>();
	}

	protected override CardScript InitCard (CardScript newCard, int index)
	{
		CYHeroCard heroCard = newCard as CYHeroCard;

		switch(index){
		case 0:
			heroCard.name = "00";
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		}

		return heroCard;
	}

}
