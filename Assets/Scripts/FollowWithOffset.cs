using UnityEngine;

public class FollowWithOffset : MonoBehaviour
{
	[SerializeField] private Vector3 offset = Vector3.zero;
	[SerializeField] Transform target;

	void Update()
	{
		transform.position = target.position + offset;
	}
}
