using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {



	public float speed;
	public float horizontalMove;
	int vertical;
	int horizontal;
	public Animator anim;

	void OnCollisionStay2D(Collision2D Other){
	}
	// Update is called once per frame
	void Update () {
		
		if(Input.GetAxisRaw ("Vertical") > 0)
		{
			anim.SetBool ("Stop",false);
			anim.Play ("UpAnimation");
			transform.position = new Vector3 (transform.position.x, transform.position.y + speed, transform.position.z);

		}else if(Input.GetAxisRaw ("Vertical") < 0)
		{
			anim.SetBool ("Stop",false);
			anim.Play ("DownAnimation");
			transform.position = new Vector3 (transform.position.x, transform.position.y -speed, transform.position.z);

		}else if(Input.GetAxisRaw ("Horizontal") > 0)
		{
			anim.SetBool ("Stop",false);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.Play ("HorizontalAnimation");
			transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		}else if(Input.GetAxisRaw ("Horizontal") < 0)
		{
			anim.SetBool ("Stop",false);
			transform.localScale = new Vector3 (-1, 1, 1);
			anim.Play ("HorizontalAnimation");
			transform.position = new Vector3 (transform.position.x - speed, transform.position.y, transform.position.z);
		} else 
		{
			anim.SetBool ("Stop",true);
		}
			
	}
}
