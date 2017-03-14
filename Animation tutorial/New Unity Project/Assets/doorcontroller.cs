using UnityEngine;
using System.Collections;

public class doorcontroller : MonoBehaviour {

	Animator animator;

	void Start () {
		animator = GetComponent<Animator>

	}

	void OnGUI () {

		if (GUILayout.Button ("Open Door")) 
		{
			Animator.SetInteger ("Door close", 1);
			Animator.SetInteger ("Door open", 0);
		}
