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
    /// Represents the single mode_de_formation object view model.
    /// </summary>
    public partial class mode_de_formationViewModel : SingleObjectViewModel<mode_de_formation, string, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of mode_de_formationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static mode_de_formationViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new mode_de_formationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the mode_de_formationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the mode_de_formationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected mode_de_formationViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.mode_de_formations, x => x.codemodef) {
                }



    }
}
