using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour {

	public float coldTime = 2f;
	public KeyCode keycode;
	private float timer = 0;
    private Image filledImage;
	private bool isStartTimber = false;

	// Use this for initialization
	void Start () {
		filledImage = transform.Find ("FilledImage").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (keycode)) {
			isStartTimber = true;
		}
		if (isStartTimber) {
			timer += Time.deltaTime;
			filledImage.fillAmount = (coldTime - timer) / coldTime;
			if (timer >= coldTime) {
				filledImage.fillAmount = 0;
				timer = 0;
				isStartTimber = false;
			}
		}
	}

	public void OnClick()
	{
		isStartTimber = true;
	}
}
