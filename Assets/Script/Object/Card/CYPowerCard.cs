using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CYPowerCard : CardScript {

	public Image Image_Ilerst;
	public Text Text_NormalPower;
	public Text Text_SpcPower;

	public int NormalPower;
	public int SpcPower;
	public SpecialType.SPC_Type mType;

	public override void Init ()
	{
		Text_NormalPower.text 	= ""+NormalPower;
		Text_SpcPower.text 		= ""+SpcPower; 
	}

	protected override void BeginDrag (UnityEngine.EventSystems.PointerEventData eventData)
	{
		base.BeginDrag (eventData);

	}

	protected override void Drag (UnityEngine.EventSystems.PointerEventData eventData)
	{
		base.Drag (eventData);

	}

	protected override void EndDrag (UnityEngine.EventSystems.PointerEventData eventData)
	{
		base.EndDrag (eventData);

	}

}
