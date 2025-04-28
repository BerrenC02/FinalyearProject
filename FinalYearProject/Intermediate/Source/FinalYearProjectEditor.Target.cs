using UnrealBuildTool;

public class FinalYearProjectEditorTarget : TargetRules
{
	public FinalYearProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FinalYearProject");
	}
}
