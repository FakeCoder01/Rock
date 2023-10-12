﻿using Assets.Resources.Scripts.CubeLogic.CubeStates;
using System;
using UnityEngine;

namespace Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials
{
	public abstract class Material : MonoBehaviour
	{
		public event Action OnPlayerDeath;

		public abstract void Visit(StandardState state);
		public abstract void Visit(FieryState state);
		public abstract void Visit(MetalState state);
		public abstract void Visit(LiquidState state);
	}
}
