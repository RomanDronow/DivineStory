using Vintagestory.API.Common;

namespace DivineStory;

public class DivineStoryModSystem : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        api.RegisterItemClass("ItemTeleportPyramid", typeof(Item.ItemTeleportPyramid));
    }
}
