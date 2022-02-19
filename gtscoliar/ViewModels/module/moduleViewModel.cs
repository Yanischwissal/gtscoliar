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
    /// Represents the single module object view model.
    /// </summary>
    public partial class moduleViewModel : SingleObjectViewModel<module, int, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of moduleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static moduleViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new moduleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the moduleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the moduleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected moduleViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.modules, x => x.module1) {
                }



    }
}
