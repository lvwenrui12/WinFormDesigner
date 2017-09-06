using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace DesignSurfaceExt  {
public class UndoEngineExt : UndoEngine {
    private string _Name_ = "UndoEngineExt";

    private Stack<UndoEngine.UndoUnit> undoStack = new Stack<UndoEngine.UndoUnit>();
    private Stack<UndoEngine.UndoUnit> redoStack = new Stack<UndoEngine.UndoUnit>();

public UndoEngineExt ( IServiceProvider provider ) : base ( provider ) {}


    public bool EnableUndo {
        get { return undoStack.Count > 0; }
    }

    public bool EnableRedo {
        get { return redoStack.Count > 0; }
    }

    public void Undo() {
        if ( undoStack.Count > 0 ) {
            try {
                UndoEngine.UndoUnit unit = undoStack.Pop();
                unit.Undo();
                redoStack.Push ( unit );
                //Log("::Undo - undo action performed: " + unit.Name);
            }
            catch ( Exception ex ) {
                //Log("::Undo() - Exception " + ex.Message + " (line:" + new StackFrame(true).GetFileLineNumber() + ")");
            }
        }
        else {
            //Log("::Undo - NO undo action to perform!");
        }
    }

    public void Redo() {
        if ( redoStack.Count > 0 ) {
            try {
                UndoEngine.UndoUnit unit = redoStack.Pop();
                unit.Undo();
                undoStack.Push ( unit );
                //Log("::Redo - redo action performed: " + unit.Name);
            }
            catch ( Exception ex ) {
                //Log("::Redo() - Exception " + ex.Message + " (line:" + new StackFrame(true).GetFileLineNumber() + ")");
            }
        }
        else {
            //Log("::Redo - NO redo action to perform!");
        }
    }


    protected override void AddUndoUnit ( UndoEngine.UndoUnit unit ) {
        undoStack.Push ( unit );
    }


}//end_class
}//end_namespace

