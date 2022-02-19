using DevExpress.Mvvm.DataModel;
using gtscoliar.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gtscoliar.gtstgDataModel {

    /// <summary>
    /// IgtstgUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IgtstgUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The anne_scoliar entities repository.
        /// </summary>
		IRepository<anne_scoliar, int> anne_scoliar { get; }
        
        /// <summary>
        /// The evaluer entities repository.
        /// </summary>
		IRepository<evaluer, Tuple<int, int, string, string>> evaluers { get; }
        
        /// <summary>
        /// The mode_de_formation entities repository.
        /// </summary>
		IRepository<mode_de_formation, string> mode_de_formations { get; }
        
        /// <summary>
        /// The module entities repository.
        /// </summary>
		IRepository<module, int> modules { get; }
        
        /// <summary>
        /// The option entities repository.
        /// </summary>
		IRepository<option, string> options { get; }
        
        /// <summary>
        /// The promo entities repository.
        /// </summary>
		IRepository<promo, int> promoes { get; }
        
        /// <summary>
        /// The section entities repository.
        /// </summary>
		IRepository<section, int> sections { get; }
        
        /// <summary>
        /// The semasetre entities repository.
        /// </summary>
		IRepository<semasetre, string> semasetres { get; }
        
        /// <summary>
        /// The Specialité entities repository.
        /// </summary>
		IRepository<Specialité, string> Specialité { get; }
        
        /// <summary>
        /// The stg entities repository.
        /// </summary>
		IRepository<stg, string> stgs { get; }
        
        /// <summary>
        /// The sysdiagram entities repository.
        /// </summary>
		IRepository<sysdiagram, int> sysdiagrams { get; }
    }
}
