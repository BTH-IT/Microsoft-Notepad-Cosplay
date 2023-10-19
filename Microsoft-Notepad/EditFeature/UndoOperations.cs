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

		public bool toggleRedo { get; set; }	

		public UndoOperations()
		{
			TxtAreaTextChangeRequired = true;	
			undoClass = new UndoClass();
			toggleRedo = false;
		}
		public string UndoClicked()
		{
			TxtAreaTextChangeRequired = false;
			toggleRedo = true;
			return undoClass.Undo();
		}
		public string RedoClicked()
		{
			TxtAreaTextChangeRequired = false;
			toggleRedo = false;
			return undoClass.Redo();
		}
		public void Add_Undo(string item)
		{
			undoClass.AddItem(item);	
		}
		public bool CanUndo()
		{
			return undoClass.CanUndo();
		}
		public bool CanRedo()
		{
			return undoClass.CanRedo();
		}
	}
}
