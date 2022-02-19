using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using gtscoliar.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gtscoliar.gtstgDataModel {

    /// <summary>
    /// A gtstgUnitOfWork instance that represents the run-time implementation of the IgtstgUnitOfWork interface.
    /// </summary>
    public class gtstgUnitOfWork : DbUnitOfWork<gtstg>, IgtstgUnitOfWork {

        public gtstgUnitOfWork(Func<gtstg> contextFactory)
            : base(contextFactory) {
        }

        IRepository<anne_scoliar, int> IgtstgUnitOfWork.anne_scoliar {
            get { return GetRepository(x => x.Set<anne_scoliar>(), (anne_scoliar x) => x.code_anne); }
        }

        IRepository<evaluer, Tuple<int, int, string, string>> IgtstgUnitOfWork.evaluers {
            get { return GetRepository(x => x.Set<evaluer>(), (evaluer x) => Tuple.Create(x.anne_scoliar, x.module, x.stagiair, x.semastre)); }
        }

        IRepository<mode_de_formation, string> IgtstgUnitOfWork.mode_de_formations {
            get { return GetRepository(x => x.Set<mode_de_formation>(), (mode_de_formation x) => x.codemodef); }
        }

        IRepository<module, int> IgtstgUnitOfWork.modules {
            get { return GetRepository(x => x.Set<module>(), (module x) => x.codemodul); }
        }

        IRepository<option, string> IgtstgUnitOfWork.options {
            get { return GetRepository(x => x.Set<option>(), (option x) => x.codeopstion); }
        }

        IRepository<promo, int> IgtstgUnitOfWork.promoes {
            get { return GetRepository(x => x.Set<promo>(), (promo x) => x.Code_Promo); }
        }

        IRepository<section, int> IgtstgUnitOfWork.sections {
            get { return GetRepository(x => x.Set<section>(), (section x) => x.numrosction); }
        }

        IRepository<semasetre, string> IgtstgUnitOfWork.semasetres {
            get { return GetRepository(x => x.Set<semasetre>(), (semasetre x) => x.somestre); }
        }

        IRepository<Specialité, string> IgtstgUnitOfWork.Specialité {
            get { return GetRepository(x => x.Set<Specialité>(), (Specialité x) => x.codesp); }
        }

        IRepository<stg, string> IgtstgUnitOfWork.stgs {
            get { return GetRepository(x => x.Set<stg>(), (stg x) => x.numstg); }
        }

        IRepository<sysdiagram, int> IgtstgUnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }
    }
}
