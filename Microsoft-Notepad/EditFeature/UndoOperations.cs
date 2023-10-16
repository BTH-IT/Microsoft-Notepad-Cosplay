using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Notepad
{
	public class UndoOperations
	{
		private UndoClass undoClass;
		public bool TxtAreaTextChangeRequired { get; set; }	

		public UndoOperations()
		{
			TxtAreaTextChangeRequired = true;	
			undoClass = new UndoClass();	
		}
		public string UndoClicked()
		{
			TxtAreaTextChangeRequired = false;
			return undoClass.Undo();
		}
		public void Add_Undo(string item)
		{
			undoClass.AddItem(item);	
		}
		public bool CanUndo()
		{
			return undoClass.CanUndo();
		}
	}
}
