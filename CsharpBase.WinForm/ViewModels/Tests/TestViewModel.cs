using System.ComponentModel;
using WinFormBase.Domain.Entities;
using WinFormBase.WinForm.Services;
using WinFormBase.WinForm.ViewModels.Bases;

namespace WinFormBase.WinForm.ViewModels.Tests;

public sealed class TestViewModel : FormViewModelBase
{
    public readonly BindingList<TestGridViewModel> TestGridItems;

    internal TestViewModel() : this(new UserInfo() { UserName = "タケムラヤスヒロ", UserCode="999" }, new MessageBoxService()) { }
    public TestViewModel(UserInfo userInfo, IMessageBoxService messageBoxService) : base(userInfo , messageBoxService)
    {
        this.StatusProgressVisible = true;

        this.TestGridItems = [];
        this.TestGridItems.ListChanged += (_, __) => GridViewModelBase<TestGridViewModel>.UpdateIndices(this.TestGridItems);
    }

    public void ProgressManual()
    {
        this.StatusProgressStyle = ProgressBarStyle.Blocks;

        this.StatusProgressMinimum = 0;
        this.StatusProgressMaximum = 100;
        this.StatusProgressValue = 50;
    }

    public void ProgressAuto()
    {
        this.StatusProgressStyle = ProgressBarStyle.Marquee;
    }

    public void AddGridItem()
    {
        TestGridViewModel newItem = new(this.TestGridItems.Count, this._messageBoxService);

        this.TestGridItems.Add(newItem);
    }

    public void DeleteGridItem()
    {
        if (!this._messageBoxService.ShowWarning($"{this.DisplayGridIndex}行目を削除します。よろしいですか？"))
        {
            return;
        }

        this.TestGridItems.RemoveAt(this.GridSelectedIndex);
    }

    protected override bool IsModifying()
    {
        throw new NotImplementedException();
    }
}
