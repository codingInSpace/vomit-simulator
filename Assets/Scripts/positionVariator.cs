using UnityEngine;
using System.Collections;

public class positionVariator : MonoBehaviour {
	public float amplitude;
	public float speed;
	private float time;

	void Start () {
		speed = (speed == 0) ? 0.2f : speed;
		amplitude = (amplitude == 0) ? 7.0f : amplitude;
		time = 1.0f;
	}

	void Update () {
		time += Time.deltaTime;
		float x = amplitude * Mathf.Cos(speed * time);
		float z = amplitude * Mathf.Sin(speed * time);
		float y = this.transform.position.y;
		this.transform.position = new Vector3(x, y, z);
	}
}
