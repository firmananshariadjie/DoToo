using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoToo.Repositories;


namespace DoToo.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly ITodoItemRepository repository;

        public MainViewModel(ITodoItemRepository repository)
        {
            this.repository = repository;
            Task.Run(async () => await LoadDataAsync());
        }

        public async Task LoadDataAsync()
        {

        }
    }
}
