using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Moq.Build
{
	public class GenerateProxies : Task
	{
		[Required]
		public ITaskItem SourceProject { get; set; }

		[Required]
		public string TargetFile { get; set; }

		public override bool Execute ()
		{
			return false;
		}
	}
}
