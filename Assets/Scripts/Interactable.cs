using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform interactionTransform;
    bool isFocused = false;
    bool hasInteracted = false;
    Transform drone;

    void Update()
    {
        if(isFocused){
            float distance = Vector3.Distance(drone.position, interactionTransform.position);
            if(!hasInteracted && distance <= radius){
                hasInteracted = true;
                Debug.Log("interacted");
            }
        }
    }

    // Called when the object starts being focused
	public void OnFocused (Transform droneTransform){
		isFocused = true;
		hasInteracted = false;
		drone = droneTransform;
    }

	// Called when the object is no longer focused
	public void OnDefocused (){
		isFocused = false;
		hasInteracted = false;
		drone = null;
	}
}
