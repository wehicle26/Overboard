// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Overboard : ModuleRules
{
	public Overboard(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
		
		PrivateDependencyModuleNames.AddRange(new string[] { "UMG", "Json", "JsonUtilities" });

	}
}
