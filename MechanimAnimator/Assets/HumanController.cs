using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{

	Animator anim;
	public Transform IKPoi;
	public float ikPosWeight;
	public Transform IKHintPoi;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
//		anim.SetFloat ("Forward", Input.GetAxis ("Vertical"));
//		anim.SetFloat ("Strafe", Input.GetAxis ("Horizontal"));
	}

	void OnAnimatorIK ()
	{
		anim.SetIKPosition (AvatarIKGoal.RightHand, IKPoi.position);
		anim.SetIKPositionWeight (AvatarIKGoal.RightHand, ikPosWeight);
		anim.SetIKHintPosition (AvatarIKHint.RightElbow, IKHintPoi.position);
		anim.SetIKHintPositionWeight (AvatarIKHint.RightElbow, 1f);
	}

	public void PlayFootStepSFX ()
	{
		Debug.Log ("FootStep");
	}
}
