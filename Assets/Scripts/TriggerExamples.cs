using UnityEngine;
using System.Collections;

public class TriggerExamples : MonoBehaviour
{
	void OnTriggerEnter ( Collider other )
	{
		Debug.Log ("Object: " + other.name + " entered trigger.");
	}
}
