﻿using System.Collections.Generic;
using Caliburn.Core;
using Gemini.Framework;
using Gemini.Framework.Services;

namespace Meshellator.Viewer.Modules.ModelEditor
{
	public class Module : ModuleBase
	{
		protected override IEnumerable<ComponentInfo> GetComponents()
		{
			yield return Singleton<IEditorProvider, EditorProvider>();
		}
	}
}