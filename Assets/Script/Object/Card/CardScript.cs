using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public abstract class CardScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	// PRIVATE
	public string Name;

	// PUBLIC
	Vector3 originLocalScale;

	// Use this for initialization
	void Start () {
		originLocalScale = transform.localScale;
	}

	public abstract void Init();

	public void CardHide(){
		//playerCard.transform.localScale = Vector3.zero;
		transform.localScale = Vector3.zero;
	}
	
	public void CardShow(){
		//playerCard.transform.localScale = Vector3.one;
		transform.localScale = originLocalScale;
	}

	

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		BeginDrag(eventData);
	}

	public void OnDrag (PointerEventData eventData)
	{
		Drag(eventData);
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		EndDrag(eventData);
	}

	protected virtual void BeginDrag (PointerEventData eventData)
	{
		
	}
	
	protected virtual void Drag (PointerEventData eventData)
	{
		
	}
	
	protected virtual void EndDrag (PointerEventData eventData)
	{
		
	}

	#endregion

}
