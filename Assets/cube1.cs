using UnityEngine;
using System.Collections;

public class cube1 : MonoBehaviour {

	private float timeleft;
	public Transform prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		if(timeleft<=0.0) {
			timeleft =1.0f;
			//Debug.Log("test");
			Instantiate(prefab, new Vector3(12, 0, 30), Quaternion.identity);	
		}
	}
}
