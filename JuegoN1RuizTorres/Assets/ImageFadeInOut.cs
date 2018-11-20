using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class ImageFadeInOut : MonoBehaviour {

    [SerializeField] int TransitionSharpness;
    private Image image;
    private Color initialColor;
    private float lerpState;
    private bool direction;

	void Start () {
        image = GetComponent<Image>();
        initialColor = image.color;
        lerpState = 0f;
        direction = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (direction) {
            lerpState += Time.deltaTime * TransitionSharpness;
            if (lerpState >= 1) { lerpState = 1; direction = false; }
        } else {
            lerpState -= Time.deltaTime * TransitionSharpness;
            if (lerpState <= 0) { lerpState = 0; direction = true; }
        }

        image.color = Color.Lerp(initialColor,Color.clear, lerpState);
	}
}
