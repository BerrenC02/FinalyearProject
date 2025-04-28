using UnrealBuildTool;

public class FinalYearProjectTarget : TargetRules
{
	public FinalYearProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FinalYearProject");
	}
}
