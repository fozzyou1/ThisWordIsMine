using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	CharacterController charController;
	public Transform point;
	public Camera MainCamera;

	void Awake() {
		charController = GetComponent<CharacterController>();

	}

	void Update(){

		if(Input.GetMouseButtonUp(0)){
			Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

			rayCasting(ray);
		}

	}

	void rayCasting(Ray ray){
		RaycastHit hitObj;
		if(Physics.Raycast(ray, out hitObj, Mathf.Infinity)){
			if(hitObj.transform.tag.Equals("Wall")){
				print(hitObj.point);
				point.position = hitObj.point;
			}
		}

	}
}
