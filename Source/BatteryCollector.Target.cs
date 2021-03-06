// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BatteryCollectorTarget : TargetRules
{
	public BatteryCollectorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		bUseUnityBuild = false;
		bUsePCHFiles = false;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("BatteryCollector");
	}
}
