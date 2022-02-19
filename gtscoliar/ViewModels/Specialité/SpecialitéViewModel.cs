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
    /// Represents the single Specialité object view model.
    /// </summary>
    public partial class SpecialitéViewModel : SingleObjectViewModel<Specialité, string, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SpecialitéViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SpecialitéViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SpecialitéViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SpecialitéViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SpecialitéViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SpecialitéViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Specialité, x => x.codesp) {
                }



    }
}
