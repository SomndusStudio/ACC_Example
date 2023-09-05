/**
* Copyright (C) 2020-2023 Schartier Isaac
*
* Official Documentation: https://www.somndus-studio.com
*/

using UnrealBuildTool;
using System.Collections.Generic;

public class ACC_CPPEditorTarget : TargetRules
{
	public ACC_CPPEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ACC_CPP" } );
	}
}
