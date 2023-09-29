using System.Collections;
using System.Collections.Generic;
using UA;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
	[SerializeField] private MovementConfig config;
    [SerializeField] private Rigidbody m_rb;
	private UA.PlayerInput.GameplayActions m_actions;


	private void OnEnable()
	{
		var i = GlobalServiceContainer.Resolve<InputManager>();
		m_actions = i.GameplayActions;
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void FixedUpdate()
	{
		var value = m_actions.LinearMovement.ReadValue<Vector3>();
		m_rb.AddRelativeForce(value,ForceMode.VelocityChange);
		m_rb.velocity = Vector3.ClampMagnitude(m_rb.velocity, config.MaxVelocity);

	}




	private void OnDisable()
	{

	}

	void OnCollisionEnter(Collision other)
	{
		// Print how many points are colliding with this transform
		Debug.Log("Points colliding: " + other.contacts.Length);

		// Print the normal of the first point in the collision.
		Debug.Log("Normal of the first point: " + other.contacts[0].normal);

		// Draw a different colored ray for every normal in the collision
		foreach (var item in other.contacts)
		{
			Debug.DrawRay(item.point, item.normal * 100, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f), 10f);
			m_rb.AddForce(item.normal * m_rb.velocity.magnitude *50.0f, ForceMode.Force);
		}
	}

}
