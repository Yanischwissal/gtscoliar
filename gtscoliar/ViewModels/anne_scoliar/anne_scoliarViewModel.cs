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
    /// Represents the single anne_scoliar object view model.
    /// </summary>
    public partial class anne_scoliarViewModel : SingleObjectViewModel<anne_scoliar, int, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of anne_scoliarViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static anne_scoliarViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new anne_scoliarViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the anne_scoliarViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the anne_scoliarViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected anne_scoliarViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.anne_scoliar, x => x.session_scoliar) {
                }



    }
}
