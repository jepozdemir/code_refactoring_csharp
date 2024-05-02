namespace CSharp.Tutorials.CodeRefactoring
{
	class UseLinq
	{
		// Before refactoring
		public List<string> FilterNamesStartingWithA(List<string> names)
		{
			var filteredNames = new List<string>();
			foreach (var name in names)
			{
				if (name.StartsWith("A"))
				{
					filteredNames.Add(name);
				}
			}
			return filteredNames;
		}

		// After refactoring
		public List<string> FilterNamesStartingWithA_Better(List<string> names)
		{
			return names.Where(name => name.StartsWith("A")).ToList();
		}
	}
}
