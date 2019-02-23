using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Glutmare {
    public class PlayerController : MonoBehaviour {

        private static readonly float MIN_MOVE_SPEED_FACTOR = 0.5F;

        [SerializeField]
        private float speed = 10;

        private float speedFactor = 0;

        private Vector2 direction;

        // Start is called before the first frame update
        private void Start ()
        {
            direction = Vector2.zero;
        }

        // Update is called once per frame
        private void Update ()
        {
            Move ();
        }

        private void FixedUpdate ()
        {
            float axisH = Input.GetAxis (AxisName.Horizontal);
            float axisV = Input.GetAxis (AxisName.Vertical);
            float factorH = Mathf.Abs (axisH);
            float factorV = Mathf.Abs (axisV);
            speedFactor = Mathf.Max (factorH, factorV);
            if (speedFactor > MIN_MOVE_SPEED_FACTOR) {
                if (factorH > factorV) {
                    direction = axisH > 0 ? Vector2.right : Vector2.left;
                } else {
                    direction = axisV > 0 ? Vector2.up : Vector2.down;
                }
            } else {
                direction = Vector2.zero;
            }
        }

        private void Move ()
        {
            if (!Vector2.zero.Equals (direction)) {
                transform.Translate (direction * speed * Time.deltaTime);
            }
        }
    }
}
