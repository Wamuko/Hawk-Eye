using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class AirPlaneMeshContr : MonoBehaviour {
    [SerializeField] private GameObject variableWing;
    [SerializeField] private GameObject tailPlane;

    private List<SkinnedMeshRenderer> skinnedMeshRenderer;
    private List<Mesh> skinnedMesh;
    private AeroplaneController aeroplaneController;

    // the target of blendShape regarding to input.
    private float rollShapeTarget;
    private float leftTailShapeTarget;
    private float rightTailShapeTarget;
    // the number blendShape.
    float rightWingShape;
    float leftWingShape;
    float rightTailUpShape;
    float rightTailDownShape;
    float leftTailUpShape;
    float leftTailDownShape;
    // the speed to change blendShape.
    float changeBlendShapeSpeed;

    private void Awake()
    {
        aeroplaneController = GetComponent<AeroplaneController>();
        if (variableWing != null)
        {
            skinnedMeshRenderer[0] = variableWing.GetComponent<SkinnedMeshRenderer>();
            skinnedMesh[0] = skinnedMeshRenderer[0].sharedMesh;
        }
        if (tailPlane != null)
        {
            skinnedMeshRenderer[1] = tailPlane.GetComponent<SkinnedMeshRenderer>();
            skinnedMesh[1] = skinnedMeshRenderer[1].sharedMesh;
        }
    }

    private void Start()
    {
        SetFirstShape();
    }

    // Update is called once per frame
    void Update ()
    {

	}
    // ブレンドシェイプの初期設定
    void SetFirstShape()
    {
        rightWingShape = 50f;
        leftWingShape = 50f;
        rightTailUpShape = 50f;
        rightTailDownShape = 50f;
        leftTailUpShape = 50f;
        leftTailDownShape = 50f;
        int a = skinnedMeshRenderer.Count;
        for(int i = 0; i < a; i++)
        {
            int b = skinnedMesh[i].blendShapeCount;
            for (int j = 0; j < b; j++)
            {
                skinnedMeshRenderer[i].SetBlendShapeWeight(j, 50f);
            }
        }
    }

    // ロールしてるかによってBlendShapeによって動かす
    void RollMeshChanger()
    {
        rollShapeTarget = aeroplaneController.RollInput * 50;
        skinnedMeshRenderer[0].SetBlendShapeWeight(0, 50f);
    }
}
