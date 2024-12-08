using System.Windows.Forms.Design;

namespace WinFormBase.Presentation.Controls;

[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip)]
public class BindableToolStripStatusLabel : ToolStripStatusLabel, IBindableComponent
{
    private BindingContext? _context = null;
    public new BindingContext? BindingContext
    {
        get => this._context ??= new BindingContext();
        set => this._context = value;
    }

    private ControlBindingsCollection? _bindings;
    public new ControlBindingsCollection DataBindings
    {
        get => this._bindings ??= new ControlBindingsCollection(this);

        set => this._bindings = value;
    }
}