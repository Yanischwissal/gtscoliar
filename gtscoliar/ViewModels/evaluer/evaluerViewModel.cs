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
    /// Represents the single evaluer object view model.
    /// </summary>
    public partial class evaluerViewModel : SingleObjectViewModel<evaluer, Tuple<int, int, string, string>, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of evaluerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static evaluerViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new evaluerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the evaluerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the evaluerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected evaluerViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.evaluers, x => x.stagiair) {
                }



    }
}
