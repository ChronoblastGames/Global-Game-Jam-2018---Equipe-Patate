using System.Collections;
using UnityEngine;

public class BackgroundMover : MonoBehaviour 
{
    [Header("Target Attributes")]
    public Transform targetTransform;

    [Header("Scrolling Attributes")]
    public float scrollSpeed = 10f;

    [Space(10)]
    public float parralaxSpeed = 2f;

    private Vector2 savedBackgroundOffset;
    private Vector2 targetBackgroundScrollDirection;

    private MeshRenderer backgroundImageMeshRenderer;
    private Material backgroudImageMaterial;

    [Space(10)]
    public bool canScroll = true;

    [Space(10)]
    public bool isBackgroundLayer = false;

    private void Start()
    {
        InitializeBackground();
    }

    private void Update()
    {
        ScrollBackground();
    }

    private void InitializeBackground()
    {
        backgroundImageMeshRenderer = GetComponent<MeshRenderer>();
        backgroudImageMaterial = backgroundImageMeshRenderer.material;

        backgroudImageMaterial.SetTextureOffset("_MainTex", Vector2.zero);

        targetBackgroundScrollDirection = new Vector2(0f, 1f);
    }

    public void SetNewTargetDirection(Vector3 mousePosition)
    {
        targetBackgroundScrollDirection.Set(mousePosition.x, mousePosition.z);
    }

    private void ScrollBackground()
    {
        if (isBackgroundLayer)
        {
            Vector3 targetPosition = targetTransform.position;
            targetPosition.y = 1f;

            transform.position = targetPosition;
        }
        else
        {
            Vector3 targetPosition = targetTransform.position;
            targetPosition.y = 0f;

            transform.position = targetPosition;
        }

        if (canScroll)
        {
            Vector2 textureOffset = backgroudImageMaterial.mainTextureOffset;

            textureOffset.x = -(transform.position.x / transform.localScale.x / parralaxSpeed);
            textureOffset.y = -(transform.position.z / transform.localScale.z / parralaxSpeed);

            backgroudImageMaterial.mainTextureOffset = textureOffset;
        }      
    }

    public void StopScroll()
    {
        canScroll = false;

        backgroudImageMaterial.SetTextureOffset("_MainTex", savedBackgroundOffset);
    }
}
