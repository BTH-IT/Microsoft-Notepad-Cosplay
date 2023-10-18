using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft_Notepad
{
	public class UndoClass
	{
		private Stack<string> UndoStack;
		public UndoClass()
		{
			UndoStack = new Stack<string>();
		}
		public void Clear()
		{
			UndoStack.Clear();	
		}
		public void AddItem(string item)
		{
			UndoStack.Push(item);
		}
		public string Undo() 
		{
			try
			{
                string item = UndoStack.Pop();
                return UndoStack.First();
            } catch
			{
                return "";
            }
		}

		public bool CanUndo()
		{
			return UndoStack.Count > 1;	
		}
		public List<string> UndoItems()
		{
			return UndoStack.ToList();	
		}
	}
}
