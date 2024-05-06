using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InvSlot : MonoBehaviour, IDragHandler
{
    public int SlotNumber { get { return slotNumber; } }

    [SerializeField] private GameManager gm;

    private int slotNumber;
    private bool isDragging;
    private int hoveredSlotNumber; // if hovering over a slot, hold its number

    private void Start()
    {
        slotNumber = transform.GetSiblingIndex();
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(!isDragging)
            Debug.Log("Started dragging " + PlayerInventory.inventory[slotNumber].Name);
        if (PlayerInventory.inventory[slotNumber] != null)
        {
            gm.StartDragSlot();
            isDragging = true;

            if (eventData.hovered.Count > 0)
            {
                foreach(GameObject g in eventData.hovered)
                {
                    InvSlot slot = g.GetComponent<InvSlot>();
                    if (slot)
                    {
                        hoveredSlotNumber = slot.SlotNumber;
                        return;
                    }
                }
                hoveredSlotNumber = -1; // not hovering over a slot
            }
        }
    }

    private void Update()
    {
        if(isDragging && Input.GetMouseButtonUp(0))
        {
            Debug.Log("Stopped dragging " + PlayerInventory.inventory[slotNumber].Name);
            
            // check hovering a slot
            if(hoveredSlotNumber >= 0)
            {
                if(hoveredSlotNumber == slotNumber)
                {
                    Debug.Log("Can't combine with self!");
                }
                else
                {
                    if(PlayerInventory.inventory[slotNumber] == null || PlayerInventory.inventory[hoveredSlotNumber] == null)
                    {
                        hoveredSlotNumber = -1;
                        isDragging = false;
                        gm.EndDragSlot();
                        return;                  
                    }

                    Debug.Log("Attempting to combine slot " + slotNumber + " with " + hoveredSlotNumber);
                    CraftData craft = CraftingManager.TryCraftMaterials(
                        PlayerInventory.inventory[slotNumber].ItemType,
                        PlayerInventory.inventory[hoveredSlotNumber].ItemType
                        );

                    if(craft != null) // found a craft data for our ingredients
                    {
                        PlayerInventory.RemoveItem(PlayerInventory.inventory[slotNumber]);
                        gm.HandleItemRemoved(slotNumber);
                        PlayerInventory.RemoveItem(PlayerInventory.inventory[hoveredSlotNumber]);
                        gm.HandleItemRemoved(hoveredSlotNumber);
                        //Add result
                        FindObjectOfType<UI>().AddItem(craft.ItemData);
                    }
                }
                hoveredSlotNumber = -1;
            }
            isDragging = false;
            gm.EndDragSlot();
        }
    }
}
