using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using gtscoliar.Database;
using System;
using System.Collections;
using System.Linq;

namespace gtscoliar.gtstgDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IgtstgUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IgtstgUnitOfWork>(() => new gtstgUnitOfWork(() => new gtstg()));
        }
    }
}