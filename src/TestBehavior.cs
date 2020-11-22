using System;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace BuildingMod
{
  class TestBehavior : BlockBehavior
  {

    int state = 0;

    public TestBehavior(Block block) : base(block)
    {
      Console.WriteLine(String.Format("TestBehavior: behavior created", this.state));
    }

    public override void OnBlockBroken(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, ref EnumHandling handling)
    {
      this.state += 1;
      world.Logger.Log(EnumLogType.Notification, String.Format("TestBehavior: State: {0}", this.state));
    }

  }
}