

using Vintagestory.API.Common;
using Vintagestory.API.Server;
using BuildingMod;

[assembly: ModInfo( "BuildingMod", "buildingmod",
  Description = "An example mod using VS Code and .NET Core",
  Website     = "https://github.com/copygirl/howto-example-mod",
  Authors     = new []{ "Sighter" })]

[assembly: ModDependency("creative")]
[assembly: ModDependency("survival")]

namespace BuildingMod
{
  class BuildingModSystem: ModSystem
  {

    public override void Start(ICoreAPI api)
    {
      base.Start(api);
      api.RegisterBlockBehaviorClass("TestBehavior", typeof(TestBehavior));
    }

    public override void StartServerSide(ICoreServerAPI api) {
      base.StartServerSide(api);
      api.RegisterBlockBehaviorClass("TestBehavior", typeof(TestBehavior));
      api.Logger.Log(EnumLogType.Notification, "this is a test");
    }

  }

}