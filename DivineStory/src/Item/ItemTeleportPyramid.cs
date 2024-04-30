using Vintagestory.API.Common;

namespace DivineStory.Item;

enum TeleportPyramidColor
{
    RED = 32,
    BLUE = 64
}

public class ItemTeleportPyramid : Vintagestory.API.Common.Item
{
    // This is the class for the item. It is a teleport pyramid.
    // It can be activated from hands to teleport to another pyramid (only two of them exist).

    // If another pyramid is in container, you will be teleported to the container.
    // If another pyramid is in inventory, you will be teleported to the player that holds it.

    private TeleportPyramidColor color;

    public override void OnLoaded(ICoreAPI api)
    {
        base.OnLoaded(api);
        color = TeleportPyramidColor.RED;
    }

    public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel,
        EntitySelection entitySel,
        bool firstEvent, ref EnumHandHandling handling)
    {
        // This method is called when the player right-clicks with the item in hands.
        // It is used to handle the teleportation.

        // If the player is sneaking, the pyramid will be activated.
        if (byEntity.Controls.Sneak)
        {
            // If the player is holding the pyramid, it will be activated.
            if (slot.Itemstack.StackSize > 0)
            {
                ItemTeleportPyramid otherPyramid = LocateAnotherPyramid(byEntity.World);
                // If the player is holding the pyramid, it will be activated.
                // The player will be teleported to the other pyramid.
                // If the other pyramid is in the player's inventory, the player will be teleported to the player.
                // If the other pyramid is in the player's container, the player will be teleported to the container.
                // The pyramid will be activated.
            }
        }
    }

    public ItemTeleportPyramid LocateAnotherPyramid(IWorldAccessor world)
    {
        // This method is used to locate the other pyramid.
        // It will return the other pyramid if it is found.
        
        // If the other pyramid is not found, it will return null.
        return null;
    }
}