using Assets.Resources.Scripts.CubeLogic.CubeStates;
using Assets.Resources.Scripts.CubeLogic.EnvironmentMaterials;

public class PoolOfWater : Water
{
	public override void Visit(StandardState state)
	{
		//��������� �������� �� ����������� ����
	}

	public override void Visit(MetalState state)
	{
		// ����� ������
	}

	public override void Visit(LiquidState state)
	{
		// ���������� ������� �������� ������ �� ����������� ����
	}
}
