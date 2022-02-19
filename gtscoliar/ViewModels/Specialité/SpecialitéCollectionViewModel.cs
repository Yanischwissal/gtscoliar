﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using gtscoliar.gtstgDataModel;
using gtscoliar.Common;
using gtscoliar.Database;

namespace gtscoliar.ViewModels {

    /// <summary>
    /// Represents the Specialité collection view model.
    /// </summary>
    public partial class SpecialitéCollectionViewModel : CollectionViewModel<Specialité, string, IgtstgUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SpecialitéCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SpecialitéCollectionViewModel Create(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SpecialitéCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SpecialitéCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SpecialitéCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SpecialitéCollectionViewModel(IUnitOfWorkFactory<IgtstgUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Specialité) {
        }
    }
}