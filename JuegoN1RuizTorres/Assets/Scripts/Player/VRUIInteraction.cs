using UnityEngine;
using UnityEngine.UI;

public class VRUIInteraction : MonoBehaviour {

    [SerializeField] float RayCastDistance;
    [SerializeField] Sprite ReticleSprite;
    [SerializeField] float MaxReticleDistance;
    private GameObject reticle;
    private int mascara;
    private RaycastHit rayInfo;

    private void Start()
    {
        reticle = new GameObject("ReticlePointer");
        reticle.transform.parent = transform;
        reticle.AddComponent<SpriteRenderer>().sprite = ReticleSprite;
        reticle.transform.position = transform.forward * RayCastDistance;
        reticle.transform.LookAt(transform.position);
        mascara = ~LayerMask.GetMask("Player");
        
    }
    void Update () {
        if (Physics.Raycast(transform.position, transform.forward, out rayInfo, RayCastDistance, mascara)){

            float reticleDistance;

            if (rayInfo.distance < MaxReticleDistance) { reticleDistance = rayInfo.distance; } else { reticleDistance = MaxReticleDistance; }
            reticle.transform.position = transform.position + (transform.forward * reticleDistance); reticle.transform.LookAt(transform.position);


            if (InputManager.Instance.GetAction() && rayInfo.collider.gameObject.layer == LayerMask.NameToLayer("UI"))
            {
                Button button = rayInfo.collider.gameObject.GetComponent<Button>();
                if (button) { button.onClick.Invoke();}
            }
        } else {
            reticle.transform.position = transform.position + (transform.forward * MaxReticleDistance); reticle.transform.LookAt(transform.position);
        }
	}
}
