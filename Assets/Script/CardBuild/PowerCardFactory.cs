using UnityEngine;
using System.Collections;

public class PowerCardFactory : ParentCardFactory {

	protected override CardScript GetCard (int index)
	{
		GameObject newResource = Resources.Load("Cards/PowerCard" + index.ToString("0000")) as GameObject;
		print ("Cards/PowerCard" + index.ToString("0000"));

		return newResource.GetComponent<CardScript>();
	}

	protected override CardScript InitCard (CardScript newCard, int index)
	{
		CYPowerCard powerCard = newCard as CYPowerCard;

		
		return newCard;
	}

}
