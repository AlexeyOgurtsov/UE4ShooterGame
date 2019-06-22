// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyShooterGameEditor_NoPrecompTarget : MyShooterGameEditorTarget
{
	public MyShooterGameEditor_NoPrecompTarget(TargetInfo Target) : base(Target)
	{
		bUseUnityBuild = false;
		bUsePCHFiles = false;	

		ExtraModuleNames.AddRange( new string[] { "MyShooterGame" } );
	}
}
