using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Player/Config/Movement", fileName = "MovementConfig")]
public class MovementConfig : ScriptableObject
{
	[field: SerializeField] public float MaxVelocity { get; private set; }
	[field: SerializeField] public float Sensitivity { get; private set; }
}
