using UnityEngine;
using UnityEngine.UI;

public class VRUIInteraction : MonoBehaviour {

    [SerializeField] float RayCastDistance;
    [SerializeField] Sprite ReticleSprite;
    [SerializeField] float ReticleDistance;
    private GameObject reticle;

    private RaycastHit rayInfo;

    private void Start()
    {
        reticle = new GameObject("ReticlePointer");
        reticle.transform.parent = transform;
        reticle.AddComponent<SpriteRenderer>().sprite = ReticleSprite;
        reticle.transform.position = transform.forward * RayCastDistance;
        reticle.transform.LookAt(transform.position);
    }
    void Update () {
        if (Physics.Raycast(transform.position, transform.forward, out rayInfo, RayCastDistance)){
            float retDist;
            if (rayInfo.distance < ReticleDistance) { retDist = rayInfo.distance; } else { retDist = ReticleDistance; }
            reticle.transform.position = transform.position + (transform.forward * retDist); reticle.transform.LookAt(transform.position);

            if (InputManager.Instance.GetAction() && rayInfo.collider.gameObject.tag == "UI")
            {
                Button but = rayInfo.collider.gameObject.GetComponent<Button>();
                if (but) { but.onClick.Invoke(); }
            }
        } else {
            reticle.transform.position = transform.position + (transform.forward * ReticleDistance); reticle.transform.LookAt(transform.position);
        }
	}
}
