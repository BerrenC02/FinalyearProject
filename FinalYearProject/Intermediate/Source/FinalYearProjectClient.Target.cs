using UnrealBuildTool;

public class FinalYearProjectClientTarget : TargetRules
{
	public FinalYearProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FinalYearProject");
	}
}
