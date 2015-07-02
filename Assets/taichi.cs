using UnityEngine;
using System.Collections;

public class taichi :MonoBehaviour {
	public Animator animator;

	private Transform target;
	// Use this for initialization
	void Start (){
		//public Animator animator = GetComponent<animator>();

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.S)){
			animator.SetTrigger  ("attack1");
		}
		
			                                                                         		
}		                                                                         
}
