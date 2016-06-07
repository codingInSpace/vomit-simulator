using UnityEngine;
using System.Collections;

public class bgColorVariator : MonoBehaviour {
	
	void Update () {
		float H, S, V;
		Color current = this.GetComponent<Camera>().backgroundColor;
		Color.RGBToHSV(current, out H, out S, out V);
		H += 0.01f;

		this.GetComponent<Camera>().backgroundColor = Color.HSVToRGB(H, S, V);
	}
}
