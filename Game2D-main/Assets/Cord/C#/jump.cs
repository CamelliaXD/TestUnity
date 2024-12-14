using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour
{
	public float jumpSpeed = 3f;
	public float jumpDelay = 2f;

	private bool canjump;
	private bool isjumping;
	private Rigidbody2D rb;
	private float countDown;
	[SerializeField] AudioSource jumpsource;

	// Start is called before the first frame update
	void Start()
	{
		canjump = true;
		rb = GetComponent<Rigidbody2D>();
		countDown = jumpDelay;
	}

	// Update is called once per frame
	void Update()
	{
		if (isjumping && countDown > 0)
			countDown -= Time.deltaTime;
		else
		{
			canjump = true;
			isjumping = false;
			countDown = jumpDelay;
		}

	}

	public void StartLetsJump()
	{
		if (canjump)
		{
			canjump = false;
			isjumping = true;
			rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
			jumpsource.Play();
		}
	}

}
