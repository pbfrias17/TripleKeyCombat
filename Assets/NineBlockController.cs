using UnityEngine;
using System.Collections;

public class NineBlockController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Transform GetChildBlockTransform(int row, int col) {
		string targetName = "Block " + row.ToString() + col.ToString();
		foreach (Transform child in transform) {
			if(child.name == targetName) {
				return child;
			}
		}
		return null;
	}
}
