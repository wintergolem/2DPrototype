using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {

	public Camera cam;
	public Vector3 startingPoint;
	public float bottomRange;
	public float topRange;
	public float left;
	public float right;
	float rand;
	// Use this for initialization
	void Start () {
		if(!cam) cam = Camera.main;
		startingPoint = transform.position;
		startingPoint.x = right;
		rand = Random.Range(bottomRange, topRange);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(rand* Time.deltaTime,0,0 );
		if(transform.position.x > left)
		{
			Reset();
		}
	}

	void Reset()
	{
		rand = Random.Range(bottomRange,topRange);
		transform.position = startingPoint;
	}
}
