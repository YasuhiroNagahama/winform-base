using System.ComponentModel;
using WinFormBase.Presentation.Services;
using WinFormBase.Presentation.ViewModels.Bases;

namespace WinFormBase.Presentation.ViewModels.Tests;

public sealed class TestViewModel : FormViewModelBase
{
    public readonly BindingList<TestGridViewModel> TestGridItems;

    internal TestViewModel() : this(new MessageBoxService()) { }
    public TestViewModel(IMessageBoxService messageBoxService) : base(messageBoxService)
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
}
