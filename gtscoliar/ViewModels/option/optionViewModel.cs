using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using gtscoliar.gtstgDataModel;
using gtscoliar.Common;
using gtscoliar.Database;

namespace gtscoliar.ViewModels {

    /// <summary>
    /// Represents the single option object view model.
    /// </summary>
    public partial class optionViewModel : SingleObjectViewModel<option, string, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of optionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static optionViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new optionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the optionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the optionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected optionViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.options, x => x.codeopstion) {
                }



    }
}
