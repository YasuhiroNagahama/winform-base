namespace WinFormBase.Presentation.Controls;

public sealed class BindableRadioButton : RadioButton
{
    public BindableRadioButton()
    {
        this.AutoCheck = true;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);

        this.Checked = !this.Checked;
    }
}
