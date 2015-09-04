using UnityEngine;
using System.Collections;

public class SkillCardFactory : ParentCardFactory {


	protected override CardScript GetCard (int index)
	{
		GameObject newCard;
		newCard = Resources.Load("Cards/SkillCard" + index.ToString("0000")) as GameObject;
		
		return newCard.GetComponent<CardScript>();
	}

	protected override CardScript InitCard (CardScript newCard, int index)
	{
		return newCard;
	}

}
