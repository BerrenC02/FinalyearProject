using UnrealBuildTool;

public class FinalYearProjectServerTarget : TargetRules
{
	public FinalYearProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FinalYearProject");
	}
}
