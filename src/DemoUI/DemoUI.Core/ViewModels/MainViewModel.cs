using DemoUI.Core.Models;
using DemoUI.Core.Services;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace DemoUI.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            var pessoas = PessoaDataService.GetAll();
            Pessoas = new ObservableCollection<Pessoa>(pessoas);


            Observable.Merge(
                    this.WhenAny(s => s.Campo1, t => t),
                    this.WhenAny(s => s.Campo2, t => t),
                    this.WhenAny(s => s.Campo3, t => t),
                    this.WhenAny(s => s.Campo4, t => t),
                    this.WhenAny(s => s.Campo5, t => t)
                )
                .Subscribe(change =>
                {
                    string propertyName = change.GetPropertyName();
                    string value = change.GetValue();
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        AddError("Esse campo não pode ficar em branco.", propertyName);
                    }
                    else
                    {
                        RemoveErrors(propertyName);
                    }
                });
        }

        [Reactive]
        public string Campo1 { get; set; }

        [Reactive]
        public string Campo2 { get; set; }

        [Reactive]
        public string Campo3 { get; set; }

        [Reactive]
        public string Campo4 { get; set; }

        [Reactive]
        public string Campo5 { get; set; }

        public ObservableCollection<Pessoa> Pessoas { get; }
    }
}
