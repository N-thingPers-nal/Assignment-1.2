using UnityEngine;

interface IInteractable
{
    public void Interact();
}


public class Interactables : MonoBehaviour
{
    //public Transform InteractorSource;
    public float InteractRange;
    public Transform InteractionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact() // enables different interactable outcomes for each type
    {
        Debug.Log("INTERACTING WITH " + transform.name);
    }

    private void Update()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, InteractionTransform.position);  //check distance to player
            if (distance <= InteractRange) 
            {
                Debug.Log("INTERACT");
                Interact();
                hasInteracted = true; //only interact once per frame
            }
        }
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false; // only interact once once focused
    }

    public void OnDefocused ()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        if (InteractionTransform == null)
            InteractionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(InteractionTransform.position, InteractRange);
    }

   // private void Update()
   // {
        //Interactable code starts _______________________________________
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    //position and direction of source
        //    Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
        //    if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        //   {
        //        // attempt interaction with object
        //        if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
        //        {
        //            interactObj.Interact();
        //        }
        //    }
        //}
        //Interactable code ends _______________________________________
   // }

}
