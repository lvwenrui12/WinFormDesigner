// IMPORTANT: Read the license included with this code archive.
using System;
using System.ComponentModel.Design.Serialization;

namespace ICSharpCode.FormsDesigner.Services
{
	internal class NameCreationService : INameCreationService
	{
		public string CreateName(System.ComponentModel.IContainer container, System.Type dataType)
		{
			int i = 0;
			string name = dataType.Name;

			// Increment counter until we find a name that's not in use
			while(true)
			{
				i++;
				if (container.Components[name + i.ToString()] == null)
					break;
			}

			return name + i.ToString();
		}

		public void ValidateName(string name)
		{
			// Use our existing method to check but then throw an exception if it's invalid
			if (!IsValidName(name))
				throw new ArgumentException("Invalid name: " + name);
		}

		public bool IsValidName(string name)
		{
			// Check that we were actually passed a name, with a length
            if (name == null || name.Length == 0)
				return false;

			// First character must be a letter
			if (!Char.IsLetter(name, 0))
				return false;

			// Don't allow a leading underscore
			if (name.StartsWith("_"))
				return false;

			// Make sure there's nothing in the proposed name that isn't a letter or digit
			for (int i = 0; i < name.Length; i++)
			{
				if (!Char.IsLetterOrDigit(name, i))
					return false;
			}

			return true;
		}

	}
}
