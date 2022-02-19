using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using gtscoliar.gtstgDataModel;

namespace gtscoliar.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the gtstg data model.
    /// </summary>
    public partial class gtstgViewModel : DocumentsViewModel<gtstgModuleDescription, IgtstgUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of gtstgViewModel as a POCO view model.
        /// </summary>
        public static gtstgViewModel Create() {
            return ViewModelSource.Create(() => new gtstgViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the gtstgViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the gtstgViewModel type without the POCO proxy factory.
        /// </summary>
        protected gtstgViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override gtstgModuleDescription[] CreateModules() {
			return new gtstgModuleDescription[] {
                new gtstgModuleDescription( "anne scoliar", "anne_scoliarCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.anne_scoliar)),
                new gtstgModuleDescription( "evaluers", "evaluerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.evaluers)),
                new gtstgModuleDescription( "mode de formations", "mode_de_formationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.mode_de_formations)),
                new gtstgModuleDescription( "modules", "moduleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.modules)),
                new gtstgModuleDescription( "options", "optionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.options)),
                new gtstgModuleDescription( "promoes", "promoCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.promoes)),
                new gtstgModuleDescription( "sections", "sectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.sections)),
                new gtstgModuleDescription( "semasetres", "semasetreCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.semasetres)),
                new gtstgModuleDescription( "Specialité", "SpecialitéCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Specialité)),
                new gtstgModuleDescription( "stgs", "stgCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.stgs)),
                new gtstgModuleDescription( "sysdiagrams", "sysdiagramCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.sysdiagrams)),
			};
        }
                		protected override void OnActiveModuleChanged(gtstgModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class gtstgModuleDescription : ModuleDescription<gtstgModuleDescription> {
        public gtstgModuleDescription(string title, string documentType, string group, Func<gtstgModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}