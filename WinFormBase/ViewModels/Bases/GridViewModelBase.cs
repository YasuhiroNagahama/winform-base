using System.ComponentModel;
using WinFormBase.Presentation.Services;

namespace WinFormBase.Presentation.ViewModels.Bases;

public abstract class GridViewModelBase<T>(int index, IMessageBoxService messageBoxService) : ViewModelBase where T : GridViewModelBase<T>
{
    protected readonly IMessageBoxService _messageBoxService = messageBoxService;

    private int _index = index;
    [Browsable(false)]
    public int Index
    {
        get => this._index;
        private set => this.SetProperty(ref this._index, value);
    }

    [DisplayName("NO")]
    public int DisplayIndex => this.Index + 1;

    public static void UpdateIndices(IEnumerable<T> items)
    {
        int currentIndex = 0;

        foreach (T item in items)
        {
            item.Index = currentIndex;

            currentIndex++;
        }
    }
}