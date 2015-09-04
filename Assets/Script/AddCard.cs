using UnityEngine;
using System.Collections;

public class AddCard : MonoBehaviour {


	public void CreateDummyCard(){
		CardBuilder.Instance.BuildCard(CardBuilder.cardType.Power, 0);
	}

}
