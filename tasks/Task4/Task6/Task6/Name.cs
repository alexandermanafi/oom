using System;

namespace Task6
{
	public class ID
	{
		private string m_name;

		public ID(string testname)
		{
			Name = testname;
		}

		public string Name
		{
			get {return m_name;}
			set {m_name = value;}
		}
	}
}

