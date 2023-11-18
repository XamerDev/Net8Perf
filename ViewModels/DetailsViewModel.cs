using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Net8Perf.ViewModels
{
    public class DetailsViewModel
    {
        public ICommand GetCommand { get; }
        public ObservableCollection<Something> SomethingCollection { get; set; } = new();
        public DetailsViewModel()
        {
            GetCommand = new Command(async()=> await GetSomething());
        }

        async Task GetSomething()
        {
            await Task.Delay(300);
            for (int i = 0; i < 100; i++)
            {
                SomethingCollection.Add(new Something() { Id=i, Text="test "+i});
            }

        }
    }

    public class Something
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
