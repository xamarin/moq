using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.MSBuild;
using Xunit;

namespace Moq.Build.Tests
{
	public class RoslynTests
	{
		[Fact]
		public async Task when_loading_project_then_succeeds ()
		{
			var workspace = MSBuildWorkspace.Create ();
			var project = await workspace.OpenProjectAsync (@"..\..\Moq.Build.Tests.csproj");

			Console.WriteLine (project.GetCompilationAsync ().Result.AssemblyName);
		}
	}
}
