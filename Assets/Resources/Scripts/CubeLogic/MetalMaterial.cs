using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalMaterial : EnvironmentMaterial
{
    [SerializeField] private bool setActiveFire; // ������� �� ����������� ���������

    private int materialType = (int)MaterialType.Metal;

    // ������ ���� ������� �� ����������� ���������

    public override void Interaction(int rigidObjectMaterial)
    {
        if (rigidObjectMaterial == (int)MaterialType.Fire)
        {
            Destroy(gameObject, 0.5f);
        }

    }

    private void Update()
    {
        if (setActiveFire)
        {
            Interaction((int)MaterialType.Fire);
        }
    }
}
