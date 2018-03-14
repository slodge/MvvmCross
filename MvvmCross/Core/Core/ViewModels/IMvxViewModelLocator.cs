// IMvxViewModelLocator.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace MvvmCross.Core.ViewModels
{
    public interface IMvxViewModelLocator
    {
        IMvxViewModel Load(Type viewModelType, IMvxBundle parameterValues, IMvxBundle savedState);

        IMvxViewModel<TParameter> Load<TParameter>(Type viewModelType, TParameter param, IMvxBundle parameterValues, IMvxBundle savedState);

        IMvxViewModel Reload(IMvxViewModel viewModel, IMvxBundle parameterValues, IMvxBundle savedState);

        IMvxViewModel<TParameter> Reload<TParameter>(IMvxViewModel<TParameter> viewModel, TParameter param, IMvxBundle parameterValues, IMvxBundle savedState);
    }
}