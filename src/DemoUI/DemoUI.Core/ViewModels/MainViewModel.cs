using DemoUI.Core.Models;
using DemoUI.Core.Services;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace DemoUI.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            var pessoas = PessoaDataService.GetAll();
            Pessoas = new ObservableCollection<Pessoa>(pessoas);

            this.WhenAnyValue(s => s.CampoUm)
                .Subscribe(v =>
                {
                    var propName = nameof(CampoUm);
                    if (string.IsNullOrWhiteSpace(v))
                    {
                        AddError("Esse campo não pode ficar em branco.", propName);
                    }
                    else
                    {
                        RemoveErrors(propName);
                    }
                });

            this.WhenAnyValue(s => s.CampoDois)
                .Subscribe(v =>
                {
                    var propName = nameof(CampoDois);
                    if (string.IsNullOrWhiteSpace(v))
                    {
                        AddError("Esse campo não pode ficar em branco.", propName);
                    }
                    else
                    {
                        RemoveErrors(propName);
                    }
                });

            this.WhenAnyValue(s => s.CampoQuatro)
                .Subscribe(v =>
                {
                    var propName = nameof(CampoQuatro);
                    if (string.IsNullOrWhiteSpace(v))
                    {
                        AddError("Esse campo não pode ficar em branco.", propName);
                    }
                    else
                    {
                        RemoveErrors(propName);
                    }
                });
        }

        public string CampoUm { get; set; }

        public string CampoDois { get; set; }

        public string CampoQuatro { get; set; }

        public ObservableCollection<Pessoa> Pessoas { get; }
    }
}
