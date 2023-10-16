using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Notepad.EditFeature
{
	public class FindNextSearch
	{
		public string SearchString { get; set; }
		public string Direction { get; set; }

		public bool MatchCase { get; set; }
		public string Content { get; set; }
		public int Position { get; set; }

		public bool Success { get;set; }
		public bool WrapAround { get;set; }
	}
}
