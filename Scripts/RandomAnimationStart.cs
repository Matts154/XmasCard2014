using UnityEngine;
using System.Collections;

public class RandomAnimationStart : MonoBehaviour {

	//public string animationName;

	// Use this for initialization
	void Start () {
		AnimationState a = this.GetComponent<Animator>().animation ["Glow"];
		a.time = Random.Range (0.0f, a.length);
	}
	
}
