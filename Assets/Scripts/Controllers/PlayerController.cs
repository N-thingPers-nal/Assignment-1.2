using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]

public class PlayerController : MonoBehaviour
{
    public LayerMask movementMask;
    public Interactables focus;

    Camera cam;
    PlayerMotor motor;
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                // if ray hits something, everything here is executed
                motor.MoveToPoint(hit.point);

                RemoveFocus();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            // Create a ray
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactables interactable = hit.collider.GetComponent<Interactables>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }


    }

    void SetFocus(Interactables newFocus)
    {
        if (newFocus != focus) //deactivate previous focus
        {
            if (focus != null) 
                focus.OnDefocused();

            focus = newFocus;
            motor.FollowTarget(newFocus);
        } 
        
        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
            focus = null;

        focus.OnDefocused();
        motor.StopFollowingTarget();
    }

}
