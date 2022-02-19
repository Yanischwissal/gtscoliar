using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using gtscoliar.gtstgDataModel;
using gtscoliar.Common;
using gtscoliar.Database;

namespace gtscoliar.ViewModels {

    /// <summary>
    /// Represents the modules collection view model.
    /// </summary>
    public partial class moduleCollectionViewModel : CollectionViewModel<module, int, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of moduleCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static moduleCollectionViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new moduleCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the moduleCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the moduleCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected moduleCollectionViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.modules) {
        }
    }
}