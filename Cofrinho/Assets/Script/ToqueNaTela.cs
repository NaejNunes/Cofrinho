using UnityEngine;
using System.Collections;

public class ToqueNaTela : MonoBehaviour {

    private Camera cam;

	// Use this for initialization
	void Start () {

        cam = GetComponent<Camera>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Cancel")) {

			Application.Quit ();

		}

            if (Input.touchCount > 0) {

                foreach (Touch touch in Input.touches) {

                    Ray ray = cam.ScreenPointToRay(touch.position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit)) {

                        GameObject Objeto = hit.transform.gameObject;

                        switch (touch.phase) {

                            case TouchPhase.Began:
                                Objeto.SendMessage("Began", SendMessageOptions.DontRequireReceiver);
                                break;

                            case TouchPhase.Ended:
                                Objeto.SendMessage("Ended", SendMessageOptions.DontRequireReceiver);
                                break;

                            case TouchPhase.Stationary:
                                Objeto.SendMessage("Stationary", SendMessageOptions.DontRequireReceiver);
                                break;

                            case TouchPhase.Moved:
                                Objeto.SendMessage("Moved", SendMessageOptions.DontRequireReceiver);
                                break;

                            case TouchPhase.Canceled:
                                Objeto.SendMessage("Canceled", SendMessageOptions.DontRequireReceiver);
                                break;

                        }

                    }

                }

            }

        }

	}

