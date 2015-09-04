using UnityEngine;
using System.Collections;

public class CardBuilder : MonoBehaviour {

	private static CardBuilder instance;
	public static CardBuilder Instance{
		get { 
			if (!instance)
			{
				instance = FindObjectOfType(typeof(CardBuilder)) as CardBuilder;
				
				if (!instance)
				{
					var obj = new GameObject("CardBuilder");
					DontDestroyOnLoad(obj);
					instance = obj.AddComponent<CardBuilder>();
				}
			}
			return instance;
		} 
	}

	public enum cardType{
		Hero,
		Power,
		Skill,
	}

	private HeroCardFactory 	heroCardFactory;
	private PowerCardFactory 	powerCardFactory;
	private SkillCardFactory 	skillCardFactory;

	void Awake(){
		heroCardFactory = GetComponent<HeroCardFactory>();
		powerCardFactory = GetComponent<PowerCardFactory>();
		skillCardFactory = GetComponent<SkillCardFactory>();

	}

	public CardScript BuildCard(cardType _cardType, int index){
		CardScript result;

		switch(_cardType){
		case cardType.Hero:
			result = heroCardFactory.CreateCard(index);
			break;
		case cardType.Power:
			result = powerCardFactory.CreateCard(index);
			break;
		case cardType.Skill:
			result = skillCardFactory.CreateCard(index);
			break;
		default:
			result = powerCardFactory.CreateCard(index);
			break;
		}

		return result;
	}


}
